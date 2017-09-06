using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DestinyApi.Models.Results
{
    public class SearchPlayerResult: RootResult
    {
        public bool HasPlayers
        {
            get
            {
                return Response.Length != 0;
            }
        }

        public bool ContainsPlayer(string displayName)
        {
            if (HasPlayers)
            {
                return Response.Where(x => x.displayName == displayName).Count() >= 1;
            }
            else {
                return false;
            }
        }

        public SearchPlayerResponse[] Response { get; set; }
    }

    public class SearchPlayerResponse
    {
        public string iconPath { get; set; }
        public int membershipType { get; set; }
        public string membershipId { get; set; }
        public string displayName { get; set; }
    }
}
