using BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ProfileWriteModel
    {
        public string UserPhoto { get; set; }
        public bool IsMale { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public ConstellationItem Constellation { get; set; }
        public IList<Keyword> Keywords { get; set; }
        public string SelfIntroduction { get; set; }
    }


    public enum ConstellationItem
    {
        [Display(Name = "白羊座")]
        Aries,
        [Display(Name = "金牛座")]
        Taurus,
        [Display(Name = "双子座")]
        Gemini,
        [Display(Name = "巨蟹座")]
        Cancer,
        [Display(Name = "狮子座")]
        Leo,
        [Display(Name = "处女座")]
        Virgo,

    }
}