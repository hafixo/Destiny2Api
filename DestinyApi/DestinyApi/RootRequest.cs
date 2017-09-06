using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DestinyApi
{
    public static class RootRequest
    {
        public static String ApiKey = "831dfc2968db40a2bfd1ec9e297a7991";
        public static String BaseUrl = "https://www.bungie.net/";
        public static Uri BaseUri
        {
            get
            {
                return new Uri(BaseUrl);
            }
        }

        public static HttpClient Web { get; set; }

        public static void LoadWeb()
        {
            if (Web == null)
            {
                var webHandler = new HttpClientHandler();
                webHandler.AllowAutoRedirect = true;
                webHandler.MaxAutomaticRedirections = 100;
                HttpClient _web = new HttpClient(webHandler) { BaseAddress = BaseUri };
                _web.DefaultRequestHeaders.Add("X-API-Key", ApiKey);
                Web = _web;
            }
        }
    }
}
