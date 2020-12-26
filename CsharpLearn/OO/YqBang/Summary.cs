using CSharplearn.OO.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class Summary : Content,IAppraise
    {
        //只有求助才有总结
        public void Agree(User Voter)
        {
            throw new NotImplementedException();
        }

        public void Disagree(User Voter)
        {
            throw new NotImplementedException();
        }

        public  void Publish()
        {
            throw new NotImplementedException();
        }
    }
}
