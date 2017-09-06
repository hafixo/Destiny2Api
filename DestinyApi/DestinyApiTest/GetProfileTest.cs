using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DestinyApi.Profile;
using System.Linq;
using DestinyApi.Models.Enum;

namespace DestinyApiTest
{
    [TestClass]
    public class GetProfileTest
    {
        [TestMethod]
        public void GetProfile()
        {
            var _profile = new GetProfile();
            var playerTest = new SearchPlayerTest();
            var holyBreadstickXbox = playerTest.GetHolyBreadstick().Response.First();

            var holyBreadstickProfile = _profile.GetProfileAsync((BungieMembershipType)holyBreadstickXbox.membershipType, holyBreadstickXbox.membershipId).Result;

        }
    }
}
