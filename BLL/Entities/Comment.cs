using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Comment : Content
    {
        //一篇文章可以有多个评论
        //一个评论必须有一个它所评论的文章
        //每个文章和评论都有一个评价
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章

        public virtual Comment Reply { get; set; } //回复的是第几楼    

        public virtual Article Article { get; set; } //一篇文章可以有多个评论

        public virtual IList<Appraise> Appraises { get; set; } //每个文章和评论都有一个评价

        public Problem Problem { get; set; } //一篇求助对应多个评论

        public Suggest Suggest { get; set; }
    }
}
