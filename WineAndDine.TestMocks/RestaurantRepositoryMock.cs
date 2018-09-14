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
            throw new NotImplementedException();
        }

        public void Delete(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Restaurant entity)
        {
            throw new NotImplementedException();
        }
    }
}
