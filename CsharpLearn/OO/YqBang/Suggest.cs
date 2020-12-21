using CSharplearn.OO.Interface;
using CSharplearn.ProcedureObject.Generic;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharplearn
{
    public class Suggest : Content, IAppraise
    {
        public string Title { get; set; }
        public string Kind { get; set; }
        public bool Award { get; set; }//是否奖励帮帮点
        //一个意见建议对应多个评论
        public IList<Comment> Comments { get; set; }
        //一个意见建议对应多个踩和赞
        public IList<Appraise> Appraises { get; set; }
        public void Agree(User Voter)
        {
            throw new NotImplementedException();
        }

        public void Disagree(User Voter)
        {
            throw new NotImplementedException();
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }






    }
}
