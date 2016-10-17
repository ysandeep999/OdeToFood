﻿using OdeToFood.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            RestaurantList = new List<Restaurant>();
            Restaurant r1 = new Restaurant { ID = 1, Name = "Paradise" };
            Restaurant r2 = new Restaurant { ID = 2, Name = "Godavari" };

            RestaurantList.Add(r1);
            RestaurantList.Add(r2);
            RestaurantList.Add(new Restaurant { ID = 3, Name = "Bawarchi" });
        }

        List<Restaurant> RestaurantList;
        public IEnumerable<Restaurant> GetAll()
        {
            return RestaurantList;
        }

        public Restaurant Get(int id)
        {
            return RestaurantList.FirstOrDefault(r => r.ID == id);
        }
    }
}
