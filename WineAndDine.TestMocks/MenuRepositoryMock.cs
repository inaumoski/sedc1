using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineAndDine.BL.ContractInterfaces.DbContracts;
using WineAndDine.BL.Models;

namespace WineAndDine.TestMocks
{
    public class MenuRepositoryMock : IMenuRepository
    {
        public MenuRepositoryMock()
        {
            if (StaticRepository.Menus == null)
            {
                InitMenus();
            }
        }

        private void InitMenus()
        {
            StaticRepository.Menus = new List<Menu>();
            Menu m = new Menu
            {
                Id = 1,
                RestaurantId = 1,
                Name = "Restoran Mece Meni",
                Items = new List<MenuItem>(),
            };

            m.Items.Add(new MenuItem
            {
                Id =1,
                Name="Vesalica",
                FoodCategory=FoodCategoryEnum.MainCourse,
                FoodType=ItemTypeEnum.Food,
            });

            m.Items.Add(new MenuItem
            {
                Id = 2,
                Name = "Svinsko File",
                FoodType = ItemTypeEnum.Food,
                FoodCategory = FoodCategoryEnum.MainCourse,
            });

            StaticRepository.Menus.Add(m);

            //Belvedere
            m = new Menu
            {
                Id = 1,
                RestaurantId = 1,
                Name = "Restoran Mece Meni",
                Items = new List<MenuItem>(),
            };

            m.Items.Add(new MenuItem
            {
                Id = 3,
                Name = "Rakija",
                FoodType = ItemTypeEnum.Drinks,
                Price = 70,
                DrinkCategory = DrinkCategoryEnum.Alcohol,
            });

            m.Items.Add(new MenuItem
            {
                Id = 4,
                Name = "Vesalica",
                FoodType = ItemTypeEnum.Food,
                FoodCategory = FoodCategoryEnum.MainCourse,
                Price = 280,

            });

            StaticRepository.Menus.Add(m);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Menu entity)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}
