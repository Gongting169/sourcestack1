using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Month(TaskMonthModel monthModel)
        {
            return View();
        }
        public ActionResult History(TaskHistoryModel historyModel)
        {
            return View();
        }
    }
}