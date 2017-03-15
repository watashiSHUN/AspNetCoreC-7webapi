using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace netFrameworkTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ReturnStr(out string temp);
            ViewBag.Title = temp;

            return View();
        }

        private void ReturnStr(out string temp)
        {
            temp = "Home Page From New Syntax";
        }
    }
}
