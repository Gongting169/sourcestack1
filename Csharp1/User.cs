using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharplearn
{
    sealed public class User : Entity, ISendMessage, IChat
    {
        //https://zhuanlan.zhihu.com/p/92362781  基础中的类和对象里面的作业：
        //    观察“一起帮”的：
        //1、注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //4、为这些类的字段和方法设置合适的访问修饰符。
        private User InvitedBy { get; set; }
        public string verificationcode { get; set; }
        public bool Register(User user)
        {


            return true;
        }
        public bool LogIn(User user)
        {
            if (user.verificationcode.Length != 4)
            {
                Console.WriteLine(" 验证码的长度只能等于4 ");
                return false;
            }
            if (user.verificationcode != "1235")
            {
                Console.WriteLine(" 验证码错误，请重新输入 ");
                return false;
            }
            if (user._name != "gty")
            {
                Console.WriteLine(" 用户名不存在 ");
                return false;
            }
            if (user._name.Length == 0)
            {
                Console.WriteLine(" 用户名不能为空  ");
                return false;
            }
            if (user._password.Length < 4 || user._password.Length > 20)
            {
                Console.WriteLine("密码的长度不能小于4，大于20");
                return false;
            }
            if (user._password.Length == 0)
            {
                Console.WriteLine(" 密码不能为空 ");
                return false;
            }
            if (user._name == "gty" && user._password == "1234" && user.verificationcode == "1235")
            {
                Console.WriteLine("恭喜！登录成功");
                return true;
            }
            else
            {
                Console.WriteLine();
                return false;
            }

        }
        // https://zhuanlan.zhihu.com/p/92470130 进一步封装里面的作业：
        //1、将之前User/Problem/HelpMoney类的字段封装成属性，其中：
        //user.Password在类的外部只能改不能读
        private string _password;
        internal string password
        {
            set { _password = value; }
        }
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        private string _name;
        public string Name
        {
            set
            {
                if (value == "admin")
                {
                    _name = "系统管理员";
                }
                else
                {
                    _name = value;
                }
            }

            get { return _name; }
        }
        //4、设计一种方式，保证：
        //每一个User对象一定有Name和Password赋值 
        public User(string name, string password)
        {
            _password = password;
            _name = name;
        }

        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //4、想一想，为什么Publish()方法不是放置在User类中呢？用户（user）发布（Publish）一篇文章（article），不正好是user.Publish(article) 么？

        //https://zhuanlan.zhihu.com/p/93224519
        //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。假设User类同时继承了ISendMessage和IChat，如何处理？
        void ISendMessage.Send()
        {
            throw new NotImplementedException();
        }
        void IChat.Send()
        {
            throw new NotImplementedException();
        }

        //https://zhuanlan.zhihu.com/p/94590467 不一样的权限管理：枚举和位运算的作业：
        //3、User类中添加一个Tokens属性，类型为TokenManager
        public TokenManager Tokens { get; set; }

        //https://zhuanlan.zhihu.com/p/93747718 string还是stringBuilder里面的作业：
        //设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。
        public string Name1
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "17bang" || value == "admin" || value == "管理员")
                {
                    Console.WriteLine("输入信息错误，请重新输入");
                    return;
                }
                else
                {
                    _name = value;
                }
            }
        }

        //1、确保用户（User）的密码（Password）：
        //长度不低于6
        //必须由大小写英语字母、数字和特殊符号（~!@#$%^&*()_+）组成
        //private string Password
        //{
        //    get
        //    {
        //        return _password;
        //    }
        //    set
        //    {
        //        if (value.Length <6)
        //        {
        //            Console.WriteLine("输入的长度不能小于6");
        //            return;
        //        }
        //        else if (value.Concat(value.ToUpper(),value.ToLower()))
        //        {
        //        }
        //        {
        //            _password = 
        //        }
        //    }
        //}

    
    }

}