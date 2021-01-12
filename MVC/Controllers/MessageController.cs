using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MessageController : BaseController
    {
        // GET: Message
        public ActionResult Index(MessageModel messageModel)
        {
            return View();
        }
    }
}