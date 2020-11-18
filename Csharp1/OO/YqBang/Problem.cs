using CSharplearn.OO.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharplearn
{
    public class Problem : Content, IAppraise
    {








        public void Agree(User Voter)
        {
            
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


















