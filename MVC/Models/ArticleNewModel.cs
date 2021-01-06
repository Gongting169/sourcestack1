using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ArticleNewModel
    {
        [Display(Name = "标题")]
        public string Title { get; set; }
        public string Body { get; set; }
        public string Category { get; set; }
        public IList<Keyword> Keywords { get; set; }

        public string Digest { get; set; }//摘要
        public string Advertising { get; set; }
        public string Content { get; set; }
        public string ContentUrl { get; set; }
        public string ContentEdit { get; set; }
    }
}