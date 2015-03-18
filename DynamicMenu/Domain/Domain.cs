using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMenu.Domain
{
    public class Data
    {
        public IEnumerable<Navbar> navbarItems()
        {
            var menu = new List<Navbar>();
            menu.Add(new Navbar { Id = 1, nameOption = "Menu1", controller = "Home", action = "Index", imageClass = "fa fa-fw fa-dashboard", estatus = true, isParent = false, parentId = 0 });
            menu.Add(new Navbar { Id = 2, nameOption = "Menu2", controller = "Home", action = "Index", imageClass = "fa fa-fw fa-bar-chart-o", estatus = true, isParent = true, parentId = 0 });
            menu.Add(new Navbar { Id = 3, nameOption = "Action", controller = "Home", action = "Dropdown", estatus = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 4, nameOption = "Another action", controller = "Home", action = "Dropdown", estatus = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 5, nameOption = "Something else here", controller = "Home", action = "Dropdown", estatus = true, isParent = false, parentId = 2 });
            menu.Add(new Navbar { Id = 6, nameOption = "Dropdown", controller = "Home", action = "Dropdown", estatus = true, isParent = true, parentId = 2 });
            menu.Add(new Navbar { Id = 7, nameOption = "Action - 2", controller = "Home", action = "Dropdown", estatus = true, isParent = false, parentId = 6 });
            menu.Add(new Navbar { Id = 8, nameOption = "Another action - 2", controller = "Home", action = "Dropdown", estatus = true, isParent = false, parentId = 6 });
            menu.Add(new Navbar { Id = 9, nameOption = "Something else here -2", controller = "Home", action = "Dropdown", estatus = true, isParent = false, parentId = 6 });
            menu.Add(new Navbar { Id = 10, nameOption = "Dropdown -2", controller = "Home", action = "Dropdown", estatus = true, isParent = true, parentId = 6 });
            menu.Add(new Navbar { Id = 11, nameOption = "Action - 3", controller = "Home", action = "Dropdown", estatus = true, isParent = false, parentId = 10 });

            return menu.ToList();
        }

        public IEnumerable<User> getUsers()
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, user = "admin", password = "12345", estatus = true, RememberMe = true });
            users.Add(new User { Id = 2, user = "lvasquez", password = "lvasquez", estatus = true, RememberMe = false });
            users.Add(new User { Id = 3, user = "invite", password = "12345", estatus = false, RememberMe = false });

            return users.ToList();
        }
    }
}