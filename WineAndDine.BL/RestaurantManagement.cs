using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineAndDine.BL.ContractInterfaces;
using WineAndDine.BL.ContractInterfaces.DbContracts;
using WineAndDine.BL.Models;

namespace WineAndDine.BL
{
    public class RestaurantManagement : IRestaurantManagement
    {
        private readonly IMenuRepository _menuRepository;
        public RestaurantManagement
            (
                IMenuRepository menuRepository
            )
        {
            _menuRepository = menuRepository;

        }
        public void AddMenu(Menu menu)
        {
            _menuRepository.Insert(menu);
        }

        public List<MenuItem> GetItemsByMenu(int menuId)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> GetItemsByRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetMenus()
        {
            var result = _menuRepository.GetAll();
            return result;
        }

        public List<Restaurant> GetRestaurants()
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetRestaurantsByLocation(string location)
        {
            throw new NotImplementedException();
        }

        public decimal RateExpensivenessRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }
    }
}
