using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PlanController : Controller
    {
        // GET: Plan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New(PlanNewModel newModel)
        {
            return View(
                new PlanNewModel()
                {
                    DayInWeeks = new List<SelectedItem>()
                    {
                 new SelectedItem() { DayInWeek = DayOfWeek.Monday},
                 new SelectedItem() { DayInWeek = DayOfWeek.Tuesday},
                 new SelectedItem() { DayInWeek = DayOfWeek.Wednesday},
                 new SelectedItem() { DayInWeek = DayOfWeek.Thursday},
                 new SelectedItem() { DayInWeek = DayOfWeek.Friday},
                 new SelectedItem() { DayInWeek = DayOfWeek.Saturday},
                 new SelectedItem() { DayInWeek = DayOfWeek.Sunday}
                    }
                });
        }
    }
}