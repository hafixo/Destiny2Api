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
            var unFormatted = 
@"using System;
using System.Net.Http;

namespace DestinyEndpints.ClassLibrary
{
    static HttpClient _Web = new HttpClient();
    const String BaseAddress = {0};
    public class DestinyApi
    {
        public DestinyApi()
        {
            
        }
";
            var baseAddress = "https://www.bungie.net/Platform";
            var addedData = $"\"{baseAddress}\"";
            return unFormatted.Replace("{0}", addedData);
        }


        private string GenerateMethod(string methodName)
        {
            return
@"
        public {0}()
        {
            //Hello
        }
";
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
}
