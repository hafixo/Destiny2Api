using DestinyApi.Models.Enum;
using DestinyApi.Models.Results;
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

        /// <summary>
        /// Will search for my GamerTag and test if my account was retrieved
        /// </summary>
        [TestMethod]
        public void SearchPlayer()
        {

            var holyBreadstickXbox = GetHolyBreadstick();

            Assert.IsTrue(holyBreadstickXbox.ContainsPlayer("Holy Breadstick"));

        }


        public SearchPlayerResult GetHolyBreadstick()
        {
            var displayName = "Holy Breadstick";
            return _playerSearch.SearchDestinyPlayerAsync(displayName, BungieMembershipType.TigerXbox).Result;

        }
    }
}
