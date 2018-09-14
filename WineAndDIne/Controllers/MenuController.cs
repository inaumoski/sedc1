using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WineAndDine.BL.ContractInterfaces;
using WineAndDine.BL.Models;
using WineAndDIne.Models;

namespace WineAndDIne.Controllers
{
    public class MenuController : Controller
    {
        //public MenuController()
        //{ }
        private readonly IRestaurantManagement _restaurantManagement;

        //constructior with Injection
        public MenuController(
            IRestaurantManagement restaurantManagement
            )
        {
            _restaurantManagement = restaurantManagement;
        }

        // GET: Menu
        public ActionResult Index()
        {
            List<Menu> menus = _restaurantManagement.GetMenus();
            List<MenuViewModel> vmList = MenuViewModel.MapList(menus);

            return View(vmList);
        }
    }
}