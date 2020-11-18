using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.Generic
{
    public class Comment : Content
    {
        public string Content{ get; set; }

        //一篇文章可以有多个评论
        public Article Article { get; set; }
        //每个文章和评论都有一个评价
        public IList<Appraise> Appraises { get; set; }
        public override void Publish()
        {
            throw new NotImplementedException();
        }
    }
}
