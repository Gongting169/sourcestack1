using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
   public  class TokenManager 
    {
        //https://zhuanlan.zhihu.com/p/94590467 不一样的权限管理：枚举和位运算的作业：
        //2、声明一个令牌管理（TokenManager）类：
        //使用私有的Token枚举_tokens存储所具有的权限
        //public  Token[] tokens { get; set; } = new Token[10];
        private Token tokens { get; set; }
        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
        public Token Add()
        {
            return Token;
        }
        //3、User类中添加一个Tokens属性，类型为TokenManager
    }
}
