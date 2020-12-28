using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MoneyTradeController : Controller
    {
        // GET: MoneyTrade
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sale()
        {
            return View();
        }
    }
}