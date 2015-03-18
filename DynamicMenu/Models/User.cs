using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMenu.Models
{
    public class User
    {
        public int Id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public bool estatus { get; set; }
        public bool RememberMe { get; set; }
    }
}