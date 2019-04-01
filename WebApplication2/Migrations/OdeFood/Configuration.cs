namespace WebApplication2.Migrations.OdeFood
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.OdeToFoodDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\OdeFood";
        }

        protected override void Seed(WebApplication2.Models.OdeToFoodDB context)
        {
            context.Restaurants.AddOrUpdate(
              t => t.Name, DummyData.getRestaurants().ToArray()
              );
            context.SaveChanges();

            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(
                      t => t.Name,
                      new Models.Restaurant {
                          Name = i.ToString(),
                          City = "nicieri",
                          Country = "sua"
                          
                      }
                 );
            }
        }
    }
}
