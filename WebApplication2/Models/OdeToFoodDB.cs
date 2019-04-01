using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class OdeToFoodDB : DbContext
    {
        public OdeToFoodDB() : base("DefaultConnection")
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }

      
    }
}