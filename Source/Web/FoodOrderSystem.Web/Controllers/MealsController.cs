using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderSystem.Web.Controllers
{
    public class MealsController : Controller
    {
        // GET: Meals
        public ActionResult Index()
        {
            return View();
        }
    }
}