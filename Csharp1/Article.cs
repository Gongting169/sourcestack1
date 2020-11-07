using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class Article : Content
    {
        public Article() : base("fg")
        {
        }

        //https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        public override void Release()
        {
            Console.WriteLine("需要消耗一个帮帮币");
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
        //https://zhuanlan.zhihu.com/p/93747718 string还是stringBuilder里面的作业：
        //确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串；而且如果标题前后有空格，将空格予以删除
        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("输入错误信息");
                    return;
                }
                else
                {
                    _Title = value.Trim();
                }
            }
        }
    }
}
