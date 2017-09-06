using System;
using System.Collections.Generic;
using System.Text;

namespace DestinyApi
{
    public class ManifestEndpoint
    {

        public const string _ManifestEndpoint = "/Destiny2/Manifest/";


        public async void GetManifestAsync()
        {
            var rawData = await RootRequest.Web.GetStringAsync(_ManifestEndpoint);
        }
    }
}
