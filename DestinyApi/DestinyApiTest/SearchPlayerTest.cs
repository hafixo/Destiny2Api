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
            var displayName = "Holy Breadstick";
            var rawData = _playerSearch.SearchDestinyPlayerAsync(displayName).Result;


            Assert.IsTrue(rawData.ContainsPlayer(displayName));
            
        }
    }
}
