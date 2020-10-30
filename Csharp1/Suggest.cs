using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
   public  class Suggest : Content
    {
        //https://zhuanlan.zhihu.com/p/92535455 被多少人误解继承里面的作业：
        //3、实例化文章和意见建议，调用他们：
        //继承自父类的属性和方法
        //自己的属性和方法

        //https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
     public  override  void Release()
        {
            Console.WriteLine("不需要帮帮币");
        }

        //https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
    }
}
