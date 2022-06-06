using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filter_Authenication.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

    }
}