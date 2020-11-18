using CSharplearn.OO.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class Summary : Content,IAppraise
    {






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
