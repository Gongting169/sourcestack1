using System.ComponentModel;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewModel
{
    public class ArticleNewModel
    {
        [StringLength(256, ErrorMessage = ("* 标题的长度不能超过255个字符"), MinimumLength = 10)]
        [Required(ErrorMessage = "* 标题不能为空")]
        [Display(Name = "标题")]
        public string Title { get; set; }

        [Required(ErrorMessage = "* 正文不能为空")]
        [MaxLength(int.MaxValue, ErrorMessage = "* 正文的长度最小是25,最大不能超过2147483647")]
        [MinLength(25, ErrorMessage = "* 正文的长度最小是25,最大不能超过2147483647")]
        public string Body { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage ="* 关键字不能为空")]
        [StringLength(25,ErrorMessage ="* 关键字的长度不能大于25",MinimumLength =1)]
        public IList<Keyword> Keywords { get; set; }

        [MaxLength(255,ErrorMessage ="* 摘要的长度不能超过255个字符")]
        public string Digest { get; set; }//摘要
        public string Advertising { get; set; }

        [Required(ErrorMessage ="* 文本不能为空")]
        [MaxLength(50, ErrorMessage = "* 文本的长度不能大于30")]
        public string Content { get; set; }
        //[Url()]
        [Required(ErrorMessage ="* 链接不能为空")]
        public string ContentUrl { get; set; }
        public string ContentEdit { get; set; }
    }
}