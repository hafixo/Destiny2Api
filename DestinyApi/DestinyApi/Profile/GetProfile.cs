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
        public const string GetProfileUrl = "Platform/Destiny2/{0}/Profile/{1}/?components={2}";

        /// <summary>
        /// Retrieves the information about the specific user
        /// </summary>
        /// <param name="membershipType">The platform the user is on</param>
        /// <param name="destinyMembershipId">The membershipId associated with this user</param>
        /// <returns>The search results for that information</returns>
        public async Task<GetProfileResult> GetProfileWithComponentsAsync(BungieMembershipType membershipType, string destinyMembershipId, params DestinyComponentType[] components)
        {
            if (components.Length == 0)
            {
                throw new Exception("Must request at least 1 component type");
            }

            var properUrl =  String.Format(GetProfileUrl, (int)membershipType, destinyMembershipId, formatComponents(components));
            var data = await RootRequest.Web.GetStringAsync(properUrl);
            return JsonConvert.DeserializeObject<GetProfileResult>(data);
        }

        public async Task<GetProfileResult> GetProfileAsync(BungieMembershipType membershipType, string destinyMembershipId)
        {
            //Is going to pass in all the available component types
            return await GetProfileWithComponentsAsync(membershipType, destinyMembershipId,
                DestinyComponentType.Profiles,
                DestinyComponentType.VenderReceipts,
                DestinyComponentType.ProfileInventoires,
                DestinyComponentType.ProfileCurrencies,
                DestinyComponentType.Characters,
                DestinyComponentType.CharacterInventories,
                DestinyComponentType.CharacterProgressions,
                DestinyComponentType.CharacterRenderData,
                DestinyComponentType.CharacterActivites,
                DestinyComponentType.CharacterEquipment,
                DestinyComponentType.ItemInstances,
                DestinyComponentType.ItemObjectives,
                DestinyComponentType.ItemPerks,
                DestinyComponentType.ItemRenderData,
                DestinyComponentType.ItemStats,
                DestinyComponentType.ItemSockets,
                DestinyComponentType.ItemTalentGrids,
                DestinyComponentType.ItemCommonData,
                DestinyComponentType.ItemPlugStates,
                DestinyComponentType.Vendors,
                DestinyComponentType.VenderCategories,
                DestinyComponentType.VendorSales,
                DestinyComponentType.Kiosks);
        }

        private string formatComponents(DestinyComponentType[] components)
        {
            var builder = new StringBuilder();
            foreach (var component in components)
            {
                builder.Append($"{(int)component},");
            }

            if (builder[builder.Length - 1] == ',')
            {
                builder.Remove(builder.Length - 1, 1);
            }

            return builder.ToString();
        }

    }
}
