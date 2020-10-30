using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
   public  class Problem : Content
    {
        //https://zhuanlan.zhihu.com/p/92362781
        //    观察“一起帮”的：
        //1、注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //2、求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        //3、帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        //4、为这些类的字段和方法设置合适的访问修饰符。
        private string _Title { get; set; }
        private string _body { get; set; }
        private DateTime _PublishDateTime { get; set; }
        private User _Author { get; set; }

        // https://zhuanlan.zhihu.com/p/92470130 进一步封装里面的作业：
        //1、将之前User/Problem/HelpMoney类的字段封装成属性，其中：
        //problem.Reward不能为负数
        private int _reward ;
        public  int reward
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("悬赏数不能为负数");
                    return;
                }
            }
            get { return _reward; }
        }
        //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        private string[] _KeyWord = new string[10];
        public string this[int index]
        {
            get { return _KeyWord[index - 1]; }
            set { _KeyWord[index - 1] = value; }
        }

        //4、设计一种方式，保证：
        //每一个Problem对象一定有Body赋值
        public Problem(string body)
        {
            _body = body;
        }
        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
        //Publish()：发布一篇求助，并将其保存到数据库 实例：
        //Load(int Id)：根据Id从数据库获取一条求助  静态：
        //Delete(int Id)：根据Id删除某个求助       静态：
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等
        //public void Publish()
        //{

        //}
        public static void Load( int id)//根据Id从数据库获取一条求助
        {

        }
        public static void Delete( int id )//根据Id删除某个求助 
        {

        }

        //https://zhuanlan.zhihu.com/p/92535455 被多少人误解继承里面的作业：
        //2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
        //3、实例化文章和意见建议，调用他们：
        //继承自父类的属性和方法
        //自己的属性和方法
        //4、再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？

        //https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：

        public  override void Release()
        {
            Console.WriteLine("需要消耗其设置悬赏数量的帮帮币");
        } 




    }

}


















