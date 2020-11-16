using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public interface  IChat
    {
        //https://zhuanlan.zhihu.com/p/93224519
        //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。假设User类同时继承了ISendMessage和IChat，如何处理？
        void Send();
    }
}
