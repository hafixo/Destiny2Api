using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenerator
{
    public class KeyModel
    {
        public Key[] Keys { get; set; }
    }

    public class Key
    {
        public string Name { get; set; }
        public string ApiKey { get; set; }
        public string OAuthUrl { get; set; }
        public int Client_id { get; set; }
    }

}
