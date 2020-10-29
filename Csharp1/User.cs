using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
     sealed  public class User
    {
        //https://zhuanlan.zhihu.com/p/92362781  基础中的类和对象里面的作业：
        //    观察“一起帮”的：
        //1、注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //2、求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        //3、帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
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
        public  string Name
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
        public User(string name ,string password) 
        {
            _password = password;
            _name = name;
        }

        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //4、想一想，为什么Publish()方法不是放置在User类中呢？用户（user）发布（Publish）一篇文章（article），不正好是user.Publish(article) 么？
        //https://zhuanlan.zhihu.com/p/92535455 被多少人误解继承里面的作业：
        //1、让User类无法被继承
        //2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
        //3、实例化文章和意见建议，调用他们：
        //继承自父类的属性和方法
        //自己的属性和方法
        //4、再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？
    }

}