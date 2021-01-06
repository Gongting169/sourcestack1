using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Problem : Content
    {
        public string Title { get; set; }
        public int Reward { get; set; }
        //public ProblemStatus Status { get; set; }
        public DateTime LatestUpdateTime { get; set; }
        public bool NeedRemoteHelp { get; set; }
        //一篇求助可以对应多个关键字
        public IList<Keyword> KeyWords { get; set; }
        //一篇求助可以对应多个评论
        public IList<Comment> Comments { get; set; }
        //一个求助状态对应多条求助
        public bool Audit { get; set; }//悬赏是否实结
    }
}
