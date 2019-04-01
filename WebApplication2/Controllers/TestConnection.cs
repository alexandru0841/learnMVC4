using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestConnection
    {
        private bool TestConnectionToDB(OdeToFoodDB dbEntity)
        {
            var connectionDIsable = false;

            if (dbEntity.Database.Exists())
            {
                connectionDIsable = true;
            }

            return connectionDIsable;
        }

    }
}