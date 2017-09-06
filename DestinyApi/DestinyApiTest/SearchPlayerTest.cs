using DestinyApi.Models.Enum;
using DestinyApi.SearchDestinyPlayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyApiTest
{
    [TestClass]
    public class SearchPlayerTest
    {
        SearchDestinyPlayer _playerSearch;
        public SearchPlayerTest()
        {
            _playerSearch = new SearchDestinyPlayer();
        }


        [TestMethod]
        public void SearchPlayer()
        {
            var displayName = "GunnaKillYa";
            var membershipType = BungieMembershipType.TigerXbox;
            var rawData = _playerSearch.SearchDestinyPlayerAsync(displayName, membershipType).Result;


            Assert.IsTrue(rawData.HasPlayers);

            if (rawData.HasPlayers)
            {
                Assert.AreEqual("4611686018429590517", rawData.Response.First().membershipId);
            }
        }
    }
}
