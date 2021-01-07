using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace MVC.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index(MessageModel messageModel)
        {
            return View();
        }
    }
}