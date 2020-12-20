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
    }
}
