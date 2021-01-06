using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities 
{
    public class Suggest:Content
    {
        public string Title { get; set; }
        public string Kind { get; set; }
        public bool Award { get; set; }//是否奖励帮帮点
        //一个意见建议对应多个评论
        public IList<Comment> Comments { get; set; }
        //一个意见建议对应多个踩和赞
        public IList<Appraise> Appraises { get; set; }
    }
}
