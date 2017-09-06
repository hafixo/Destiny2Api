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

        public SearchDestinyPlayer()
        {
            RootRequest.LoadWeb();
        }

        public const string SearchPlayerUrl = "Platform/Destiny2/SearchDestinyPlayer/{0}/{1}/";

        
        /// <summary>
        /// Searches for the player on the specific platform or all
        /// </summary>
        /// <param name="displayName">The username to search for</param>
        /// <param name="membershipType">The platform the user is on, or defaults to all</param>
        /// <returns>The search results from the specific query</returns>
        public async Task<SearchPlayerResult> SearchDestinyPlayerAsync(string displayName, BungieMembershipType membershipType = BungieMembershipType.All)
        {
            var properUrl = String.Format(SearchPlayerUrl, (int)membershipType, displayName);
            var rawData = await RootRequest.Web.GetStringAsync(properUrl);
            return JsonConvert.DeserializeObject<SearchPlayerResult>(rawData);
        }


    }
}
