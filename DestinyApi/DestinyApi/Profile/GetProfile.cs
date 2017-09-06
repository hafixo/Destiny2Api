using DestinyApi.Models.Enum;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DestinyApi.Models.Results;

namespace DestinyApi.Profile
{
    public class GetProfile
    {
        public GetProfile()
        {
            RootRequest.LoadWeb();
        }



        /// <summary>
        /// /Destiny2/{membershipType}/Profile/{destinyMembershipId}/
        /// </summary>
        public const string GetProfileUrl = "Platform/Destiny2/{0}/Profile/{1}/?components=100,103";

        /// <summary>
        /// Retrieves the information about the specific user
        /// </summary>
        /// <param name="membershipType">The platform the user is on</param>
        /// <param name="destinyMembershipId">The membershipId associated with this user</param>
        /// <returns>The search results for that information</returns>
        public async Task<GetProfileResult> GetProfileAsync(BungieMembershipType membershipType, string destinyMembershipId)
        {
            var properUrl =  String.Format(GetProfileUrl, (int)membershipType, destinyMembershipId);
            var data = await RootRequest.Web.GetStringAsync(properUrl);
            return JsonConvert.DeserializeObject<GetProfileResult>(data);
        }

    }
}
