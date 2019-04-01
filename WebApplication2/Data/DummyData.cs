using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class DummyData
    {
        public static List<Restaurant> getRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    City = "Brasov",
                    Country = "Romania",
                    Id = 1,
                    Name = "Iuda si prietenii",
                      Reviews = new List<RestaurantReview>{
                        new RestaurantReview{  Rating = 7,  Body = "mancare 1111", ReviwerName ="relu" },
                        new RestaurantReview{  Rating = 8,  Body = "mancare 2222", ReviwerName ="ion" },
                        new RestaurantReview{  Rating = 10,  Body = "mancare 3333", ReviwerName ="maria", RestaurantID = 1 }
                    }

                },
                 new Restaurant()
                {
                    City = "cluj",
                    Country = "Romania",
                    Id = 2,
                    Name = "la chinezu",
                    Reviews = new List<RestaurantReview>{
                        new RestaurantReview{  Rating = 9,  Body = "mancare excelent", ReviwerName ="johnescu" , RestaurantID = 2 },
                         new RestaurantReview{  Rating = 10,  Body = " asa si asa", ReviwerName ="johnescu222", RestaurantID = 2 }
                    }
                },
                  new Restaurant()
                {
                    City = "constanta",
                    Country = "Romania",
                    Id = 3,
                    Name = "unguri bre",
                    Reviews = new List<RestaurantReview>{
                        new RestaurantReview{  Rating = 3,  Body = "mancare grea", ReviwerName ="tata", RestaurantID = 3 }
                    }
                }
            };

            return restaurants;
        }

       

    }
}