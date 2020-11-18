using CSharplearn.OO.Interface;
using CSharplearn.ProcedureObject.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class Article : Content, IAppraise
    {
        public string Title { get; set; }
        public User User { get; set; }
        //每个文章和评论都有一个评价
        //一篇文章可以有多个评论
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public IList<Comment> Comments { get; set; }
        public IList<KeyWord> KeyWords { get; set; }
        public IList<Appraise> Appraises { get; set; }
        public int CommentCount { get; set; }

        public void Agree(User Voter)
        {
            throw new NotImplementedException();
        }

        public void Disagree(User Voter)
        {
            throw new NotImplementedException();
        }

        public override void Publish()
        {
            throw new NotImplementedException();
        }
    }


}
