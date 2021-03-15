using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Activate()
        {
            return View();
        }
    }
}