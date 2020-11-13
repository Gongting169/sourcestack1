using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
   public  class Entity<T>
    {
        //https://zhuanlan.zhihu.com/p/92535455 被多少人误解继承里面的作业：
        //4、再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？
          public T  Id { get; }
    }
}
