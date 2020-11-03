using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class Suggest : Content
    {
        public Suggest(string kind) : base("fg")
        {
        }

        //https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        public override void Release()
        {
            Console.WriteLine("不需要帮帮币");
        }

        //https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        public override void Agree()
        {
            Bangpoint++;
        }
        public override void Disagree()
        {
            Bangpoint--;
        }
    }
}
