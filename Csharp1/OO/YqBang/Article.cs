using CSharplearn.OO.Interface;
using CSharplearn.ProcedureObject.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class Article : Content, IAppraise
    {
        public IList<Comment<Article>> Comments { get; set; }
        public IList<KeyWord> KeyWords { get; set; }
        public IList<Appraise<Article>> Appraises { get; set; }
        public User User { get; set; }

        public void Agree(User Voter)
        {
            throw new NotImplementedException();
        }

        public void Disagree(User Voter)
        {
            throw new NotImplementedException();
        }
    }


}
