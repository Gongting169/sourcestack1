﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class HelpMoney
    {
        //https://zhuanlan.zhihu.com/p/92362781 面向对象：基础中的类和对象里面的作业：
        //    观察“一起帮”的：
        //3、帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        //4、为这些类的字段和方法设置合适的访问修饰符
        private DateTime Time { get; set; }
        public void BangMoney()
        {

        }

        // https://zhuanlan.zhihu.com/p/92470130 进一步封装里面的作业：
        //2、调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法
        public HelpMoney()
        {

        }

        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：

        //https://zhuanlan.zhihu.com/p/92535455 被多少人误解继承里面的作业：
        //让User类无法被继承
        //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
        //实例化文章和意见建议，调用他们：
        //继承自父类的属性和方法
        //自己的属性和方法
        //再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？

  


    }
}
