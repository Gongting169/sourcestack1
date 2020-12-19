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
                    throw new ArgumentOutOfRangeException("Id为{Id}的用户设置的文章的标题为{Title}输入的Reward{value}超出了范围");
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


















