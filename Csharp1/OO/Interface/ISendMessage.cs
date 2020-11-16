using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //https://zhuanlan.zhihu.com/p/93224519
    //引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），用Console.WriteLine() 实现Send()。
    public interface  ISendMessage
    {
        void Send();
    }
}
