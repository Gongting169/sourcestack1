using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities 
{
    public class Comment:Content
    {
        public int Floor { get; set; }//代表的是第几楼
        public string Response { get; set; } //回复的是第几楼
        public bool NeedRemoteHelp { get; set; }//是够需要开启远程协助

        //一篇文章可以有多个评论
        public virtual Article Article { get; set; }
        //每个文章和评论都有一个评价
        public virtual IList<Appraise> Appraises { get; set; }
        //一篇求助对应多个评论
        public  Problem Problem { get; set; }
        public  Suggest Suggest { get; set; }
    }
}
