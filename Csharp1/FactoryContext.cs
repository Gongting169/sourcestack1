using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class FactoryContext :Entity 
    {
        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //3、设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
        private static FactoryContext instance = new FactoryContext(); //创建一个FactoryContext的对象
        private  FactoryContext() //让构造函数为private，该类就不会被实例化
        {

        }
        public static FactoryContext Getinstance() //获取唯一可用的对象
        {
            return instance;
        }

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
