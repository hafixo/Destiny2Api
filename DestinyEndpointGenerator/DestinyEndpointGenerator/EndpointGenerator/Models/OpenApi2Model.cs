using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DestinyEndpointGenerator.EndpointGenerator.Models
{
    public class OpenApi2Model
    {
        public string swagger { get; set; }
        public Info info { get; set; }
        public string host { get; set; }
        public string basePath { get; set; }
        public Dictionary<string, Endpoint> paths { get; set; }
    }

    public class Endpoint
    {
        public Get get { get; set; }
    }

    public class Get {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }

    }

    public class Info
    {
        public string title { get; set; }
        public string description { get; set; }
        public string termsOfService { get; set; }
        public Contact contact { get; set; }
        public License license { get; set; }
        public string version { get; set; }
    }

    public class Contact
    {
        public string name { get; set; }
        public string url { get; set; }
        public string email { get; set; }
    }

    public class License
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}