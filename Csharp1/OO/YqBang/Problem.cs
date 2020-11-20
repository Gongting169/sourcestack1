using CSharplearn.OO.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharplearn
{
    public class Problem : Content, IAppraise
    {
        private int reward;
        public int Reward
        {
            get { return reward; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("输入的参数超出范围了");
                }
                else
                {
                    reward = value;
                }
            }
        }







        public void Agree(User Voter)
        {

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


















