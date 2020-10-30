using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class Repoistory :Entity 
    {
        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //1、定义一个仓库（Repoistory）类，用于存取对象，其中包含：
        //一个int类型的常量version
        //一个静态只读的字符串connection，以后可用于连接数据库
        private const  int version =0;
        static readonly string connection;
        //思考Respoitory应该是static类还是实例类更好  实例会更好一点，用于存取对象 因为：能实例就不要静态，尽可能的用对象自有的数据来完成方法。

        


    }
}
