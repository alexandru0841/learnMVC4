using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
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
        [Authorize(Roles = "Admin")]
        public ActionResult Search(string name = "xxxxxxxx")
        {
            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}