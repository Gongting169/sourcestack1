﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class Summary :Content
    {
        public Summary(string kind) : base(kind)
        {
        }

        //https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        public User Observer { get; set; }
        public int Bangpoint { get; set; }

        public override void Agree()
        {
            throw new NotImplementedException();
        }

        public override void Disagree()
        {
            throw new NotImplementedException();
        }


    }
}