using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DestinyEndpointGenerator.EndpointGenerator.Models;
using System.Linq;

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
                bigStringBuilder.Append(GenerateHelperStatement());


                //Add all the methods in
                foreach (var method in _Model.paths)
                {

                    if (method.Value.get != null)
                    {
                        methodBuilder.Append(GenerateMethod(method.Value.get.operationId.Replace(".", "_"), method.Value.get.description, method.Key, method.Value.get.parameters));
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
using System.Collections.Generic;

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


        private string GenerateHelperStatement()
        {
            return
@"
        private string FormatWithParameters(string input, Dictionary<string, string> ParamKeyPairs)
        {
            if(ParamKeyPairs == null)
            {
                return input;
            }
            var workingOutput = input;
            foreach (var param in ParamKeyPairs)
            {
                workingOutput = workingOutput.Replace({ParamKey}, param.Value);
            }
            return workingOutput;
        }
".Replace("{ParamKey}", String.Concat("\"", "{\"", "+", "param.Key","+", "\"}", "\""));

        }

        


        private string GenerateMethod(string methodName, string description, string route, Parameter[] _params)
        {
            return
@"
        {SummaryStatement}
        public async Task<String> {methodName}Async({ParamLine})
        {
            return await _Web.GetStringAsync(BaseAddress + FormatWithParameters({route}, {ParamDictionary}));
        }

        {SummaryStatement}
        public String {methodName}({ParamLine})
        {
            return {methodName}Async({ParamPass}).Result;
        }
".Replace("{methodName}", methodName).Replace("{SummaryStatement}", GenerateSummaryStatement(description)).Replace("{route}", $"\"{route}\"").Replace("{ParamLine}", BuildParamStateIfPossible(_params)).Replace("{ParamDictionary}", BuildParamDictionIfPossible(_params)).Replace("{ParamPass}", ParamPassThrough(_params));
        }

        private string ParamPassThrough(Parameter[] _params)
        {
            if (_params == null || _params.Length == 0)
            {
                return String.Empty;
            }
            else {
                var builder = new StringBuilder();

                foreach (var param in _params.Where(x => x.location == "path").OrderBy(x => x.required))
                {
                    builder.Append(String.Format("{0},", param.name));
                }

                if (builder.Length != 0 && builder[builder.Length - 1] == ',')
                {
                    builder.Remove(builder.Length - 1, 1);
                }

                return builder.ToString();
            }
        }

        private string BuildParamDictionIfPossible(Parameter[] _params)
        {
            if (_params == null || _params.Where(x => x.location == "path").Count() == 0)
            {
                return "null";
            }
            else {
                var builder = new StringBuilder();

                var innerBuilder = new StringBuilder();

                foreach (var item in _params.Where(x => x.location == "path").OrderBy(x => x.required))
                {
                    innerBuilder.Append("{\"{param}\", {param}.ToString()},".Replace("{param}", item.name));
                }

                if (innerBuilder[innerBuilder.Length - 1] == ',')
                {
                    innerBuilder.Remove(innerBuilder.Length - 1, 1);
                }
                


                

                builder.Append("new Dictionary<string,string>(){"+ innerBuilder.ToString() + "}");

                return builder.ToString();
            }
        }

        private string BuildParamStateIfPossible(Parameter[] _params)
        {

            var typeToDataMatch = new Dictionary<String, String>() {
                { "int64", "long" },
                { "int32", "int" },
                { "string", "string"},
                { "boolean", "bool"}
            };

            if (_params == null || _params.Length == 0)
            {
                return String.Empty;
            }
            else {
                var builder = new StringBuilder();

                foreach (var param in _params.Where(x=>x.location=="path").OrderBy(x=>x.required))
                {
                    var maybeType = typeToDataMatch.Where(x => x.Key == param.format).FirstOrDefault();
                    builder.Append(String.Format("{0} {1},", maybeType.Value != null ? maybeType.Value : "object", param.name));
                }

                if (builder.Length != 0 && builder[builder.Length-1] == ',')
                {
                    builder.Remove(builder.Length - 1, 1);
                }

                return builder.ToString();

            }
        }

        private string GenerateSummaryStatement(string description)
        {
            string template = 
@"/// <summary>
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
}
