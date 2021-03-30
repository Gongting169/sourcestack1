﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SRV.ViewModel
{
    public class CommentModel
    {
        [AllowHtml]
        [Required(ErrorMessage = "* 评论的内容不能为空")]
        public string CommentBody { get; set; }

        public CommentModel Reply { get; set; }

        public string Location { get; set; }

        public string CommentCount { get; set; }

        public ArticleSingleModel ArticleSingleModel { get; set; }

        public IList<AppraiseModel> Appraises { get; set; }
    }
}
