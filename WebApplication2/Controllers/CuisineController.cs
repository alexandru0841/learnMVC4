using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Filters;

namespace WebApplication1.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        // GET: Cuisine

        //public ActionResult Search()
        //{
        //    return Content("new controller");
        //}

        //public ActionResult Search(string name = "xxxxxxxx")
        //{
        //    var message = Server.HtmlEncode(name);

        //    return RedirectPermanent("http://google.com");
        //}

        public ActionResult Search(string name = "xxxxxxxx")
        {
            throw new Exception("Something therible");
            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}