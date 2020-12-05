using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    public class Comment :Content
    {


        //一篇文章可以有多个评论
        public Article Article { get; set; }
        //每个文章和评论都有一个评价
        public IList<Appraise> Appraises { get; set; }
    }
}
