using DestinyApi.Models.Enum;
using DestinyApi.Models.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DestinyApi.SearchDestinyPlayer
{
    public class SearchDestinyPlayer
    {
        public const string SearchPlayerUrl = "Platform/Destiny2/SearchDestinyPlayer/{0}/{1}/";
        public async Task<SearchPlayerResult> SearchDestinyPlayerAsync(string displayName, BungieMembershipType membershipType)
        {
            var properUrl = String.Format(SearchPlayerUrl, membershipType, displayName);
            var rawData = await RootRequest.Web.GetStringAsync(properUrl);
            return JsonConvert.DeserializeObject<SearchPlayerResult>(rawData);
        }
    }
}
