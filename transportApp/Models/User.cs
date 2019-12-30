using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace transportApp.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string group { get; set; }

        public User(string un, string pw, string grp = "kind")
        {
            username = un;
            password = pw;
            group = grp;
        }

    }
}