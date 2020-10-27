using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class Repoistory
    {
        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //1、定义一个仓库（Repoistory）类，用于存取对象，其中包含：
        //一个int类型的常量version
        //一个静态只读的字符串connection，以后可用于连接数据库
        private const  int version =0;
        static readonly string connection;
        //思考Respoitory应该是static类还是实例类更好  实例会更好一点，用于存取对象 因为：

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
