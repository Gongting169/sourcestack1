using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Article : Content
    {
        //一篇文章可以有多个评论
        //一个评论必须有一个它所评论的文章
        //每个文章和评论都有一个评价
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public string Title { get; set; }

        public virtual IList<Comment> Comments { get; set; }

        public virtual IList<Keyword> KeyWords { get; set; }

        public virtual IList<Appraise> Appraises { get; set; }

        public Category Category { get; set; }


    }
}
