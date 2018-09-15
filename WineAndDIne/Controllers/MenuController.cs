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
        private readonly ILogger _logger;

        //constructior with Injection
        public MenuController(
            IRestaurantManagement restaurantManagement
            , ILogger logger
            )
        {
            _restaurantManagement = restaurantManagement;
            _logger = logger;
        }

        // GET: Menu
        public ActionResult Index()
        {
            _logger.LogInfo("!!! Menus View Opened!!!");
            List<Menu> menus = _restaurantManagement.GetMenus();
            List<MenuViewModel> vmList = MenuViewModel.MapList(menus);

            return View(vmList);
        }

        public ActionResult Create()
        {
            MenuViewModel model = new MenuViewModel();
            var allRestaurants = _restaurantManagement.GetRestaurants();
            foreach (var x in allRestaurants)
            {
                model.AllRestaurants.Add(new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(MenuViewModel model)
        {
            try
            {
                _restaurantManagement.AddMenu(model.MapToBusinessModel());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                throw;
            }
            return RedirectToAction("Index");
        }

    }
}