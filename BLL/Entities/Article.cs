using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Article:Content
    {
        public string Title { get; set; }
        //每个文章和评论都有一个评价
        //一篇文章可以有多个评论
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        //一个分类对应多篇文章
        public virtual  IList<Comment> Comments { get; set; }
        public virtual IList<Keyword> KeyWords { get; set; }
        public virtual IList<Appraise> Appraises { get; set; }
        public  Category Category { get; set; }
    }
}
