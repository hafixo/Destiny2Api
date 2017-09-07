using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DestinyEndpointGenerator.EndpointGenerator.Models;

namespace DestinyEndpointGenerator.EndpointGenerator
{
    public class Generator
    {
        static HttpClient _Web = new HttpClient();

        OpenApi2Model _Model;

        public bool ModelIsLoaded
        {
            get
            {
                return _Model != null;
            }
        }

        public bool ErrorLoadingModel = false;

        public Generator()
        {
            
        }

        public async Task LoadApiDocsAsync()
        {
            try
            {
                var rawData = await _Web.GetStringAsync("https://raw.githubusercontent.com/Bungie-net/api/master/openapi-2.json");



                _Model = JsonConvert.DeserializeObject<OpenApi2Model>(rawData);
                ErrorLoadingModel = false;
            }
            catch (Exception)
            {
                ErrorLoadingModel = true;
            }
        }

        public async Task<String> GenerateClassLibraryAsync()
        {
            return await Task.Factory.StartNew(()=> {



                while (!ModelIsLoaded) { }




                var bigStringBuilder = new StringBuilder();
                var methodBuilder = new StringBuilder();
                bigStringBuilder.Append(GenerateUsingStatements());



                //Add all the methods in
                foreach (var method in _Model.paths)
                {
                    if (method.Value.get != null)
                    {
                        methodBuilder.Append(GenerateMethod(method.Value.get.operationId.Replace(".", "_"), method.Value.get.description));
                    }
                }

                bigStringBuilder.Append(methodBuilder.ToString());

                bigStringBuilder.Append(GenerateEndingStatements());

                return bigStringBuilder.ToString();

            });
        }

        private string GenerateUsingStatements()
        {

            var baseAddress = "https://www.bungie.net/Platform";
            var addedData = $"\"{baseAddress}\"";

            return 
@"using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DestinyEndpints.ClassLibrary
{
    
    public class DestinyApi
    {
        private static HttpClient _Web = new HttpClient();
        const String BaseAddress = {0};

        public DestinyApi(string apiKey)
        {
            _Web.DefaultRequestHeaders.Add({xApiKeyReference}, apiKey);
        }
".Replace("{0}", addedData).Replace("{xApiKeyReference}", $"\"{"X-API-Key"}\"");
        }


        private string GenerateMethod(string methodName, string description)
        {
            return
@"
        {SummaryStatement}
        public async Task<String> {methodName}Async()
        {
            return await _Web.GetStringAsync(BaseAddress);
        }

        {SummaryStatement}
        public String {methodName}()
        {
            return {methodName}Async().Result;
        }
".Replace("{methodName}", methodName).Replace("{SummaryStatement}", GenerateSummaryStatement(description));
        }

        private string GenerateSummaryStatement(string description)
        {
            string template = 
@"
        /// <summary>
        /// {Description}
        /// </summary>
        /// <returns>A json string for this endpoint</returns>";


            return template.Replace("{Description}", description);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GenerateEndingStatements()
        {
            return 
@"
    }
}
                    ";
        }

    }

    public class DestinyApi
    {
        static HttpClient _Web = new HttpClient();
        const String BaseAddress = "https://www.bungie.net/Platform";

        public DestinyApi()
        {

        }

        public async Task<String> User_GetBungieNetUserByIdAsync()
        {
            return await _Web.GetStringAsync(BaseAddress);
        }

        public String User_GetBungieNetUserById()
        {
            return User_GetBungieNetUserByIdAsync().Result;
        }

    }

}
