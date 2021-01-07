using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class PlanNewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<Keyword> Keywords { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DaysOfLeave { get; set; }
        public string ProofUrl { get; set; }
        public string ProofText { get; set; }
        public int MaxNumberOfSupervisors { get; set; }
        public int CurrentCredit { get; set; }
        public int PunishCount { get; set; }
        public string Continue { get; set; }
        public IList<SelectedItem> DayInWeeks { get; set; }


    }

    public class SelectedItem
    {
        public bool Checked { get; set; }
        public DayOfWeek DayInWeek { get; set; }
    }
}