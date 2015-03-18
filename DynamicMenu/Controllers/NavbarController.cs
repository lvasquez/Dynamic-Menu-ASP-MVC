using DynamicMenu.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMenu.Controllers
{
  
    public class NavbarController : Controller
    {
        // GET: Navbar
        [Authorize]
        public ActionResult Navbar()
        {

            var data = new Data();

            var items = data.navbarItems().ToList();

            return PartialView("_Navbar", items);
        }
    }
}