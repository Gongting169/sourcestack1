using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class HelpMoney
    {
        //https://zhuanlan.zhihu.com/p/92362781
        //    观察“一起帮”的：
        //1、注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //2、求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        //3、帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        //4、为这些类的字段和方法设置合适的访问修饰符。

        private DateTime Time;
        private int Amount;
        private int frozen;
        private string kind;
        private string change;
        private string notes;

        public void BangMoney()
        {

        }
        public void reason()//用来记录冻结的money
        {

        }
       
    }
}
