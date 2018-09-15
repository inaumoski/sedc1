using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineAndDine.BL.ContractInterfaces.DbContracts;
using WineAndDine.BL.Models;

namespace WineAndDine.TestMocks
{
    public class RestaurantRepositoryMock : IRestaurantRepository
    { 
        public RestaurantRepositoryMock()
        {
            if (StaticRepository.Restaurants == null)
            {
                InitRestaurants();
            }
        }

        private void InitRestaurants()
        {
            StaticRepository.Restaurants = new List<Restaurant>();

            StaticRepository.Restaurants.Add(new Restaurant { Id=1, Name="Kaj Mece"});
            StaticRepository.Restaurants.Add(new Restaurant { Id = 2, Name = "Belvedere" });
        }

        public void Delete(int id)
        {
            StaticRepository.Restaurants.RemoveAll(x => x.Id == id);
        }

        public void Delete(Restaurant entity)
        {
            if (entity == null)
            {
                return;
            }
            StaticRepository.Restaurants.RemoveAll(x => x.Id == entity.Id);
        }

        public List<Restaurant> GetAll()
        {
            return StaticRepository.Restaurants;
        }

        public void Insert(Restaurant entity)
        {
            int maxId = StaticRepository.Restaurants.Max(x => x.Id);
            entity.Id = maxId + 1;
            StaticRepository.Restaurants.Add(entity);
        }
    }
}
