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

        public Generator()
        {
            
        }

        public async Task LoadApiDocsAsync()
        {
            var rawData = await _Web.GetStringAsync("https://raw.githubusercontent.com/Bungie-net/api/master/openapi-2.json");

            

            _Model = JsonConvert.DeserializeObject<OpenApi2Model>(rawData);
        }

        public async Task<String> GenerateClassLibraryAsync()
        {
            return await Task.Factory.StartNew(()=> {

                while (!ModelIsLoaded) { }


                var bigStringBuilder = new StringBuilder();
                bigStringBuilder.Append(GenerateUsingStatements());

                //Add all the methods in


                //A sample hard coded method added in
                bigStringBuilder.Append(GenerateMethod(_Model.paths.UserGetBungieNetUserByIdid.get.operationId.Replace(".", "_")));

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
        static HttpClient _Web = new HttpClient();
        const String BaseAddress = {0};

        public DestinyApi(string apiKey)
        {
            _Web.DefaultRequestHeaders.Add({xApiKeyReference}, apiKey);
        }
".Replace("{0}", addedData).Replace("{xApiKeyReference}", $"\"{"X-API-Key"}\"");
        }


        private string GenerateMethod(string methodName)
        {
            return
@"
        public async Task<String> {methodName}Async()
        {
            return await _Web.GetStringAsync(BaseAddress);
        }

        public String {methodName}()
        {
            return {methodName}Async().Result;
        }
".Replace("{methodName}", methodName);
        }


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
