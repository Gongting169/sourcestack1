using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
   public class ContentService
    {
        //https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        //1、添加一个新类ContentService，其中有一个发布（Publish()）方法：
        //如果发布Article，需要消耗一个帮帮币
        //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
        //如果发布Suggest，不需要消耗帮帮币
        //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine() 代替。根据我们学习的继承和多态知识，实现上述功能。
        [HelpMoneyChanged(Amount = 1)]
        public void  Publish(Content content)
        {
            //content.Release();
            Console.WriteLine("保存到数据库");
            
        }


    }
}
