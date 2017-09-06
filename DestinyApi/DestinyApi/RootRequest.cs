using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DestinyApi
{
    public static class RootRequest
    {
        public static String ApiKey = "831dfc2968db40a2bfd1ec9e297a7991";
        public static String BaseUrl = "https://bungie.net/Platform";
        public static Uri BaseUri
        {
            get
            {
                return new Uri(BaseUrl);
            }
        }
        internal static HttpClient _Web { get; } = new HttpClient() { BaseAddress = BaseUri};
        public static HttpClient Web
        {
            get
            {
                if (!_Web.DefaultRequestHeaders.Contains("X-API-Key"))
                {
                    _Web.DefaultRequestHeaders.Add("X-API-Key", ApiKey);
                }
                return _Web;
            }
        }
    }
}
