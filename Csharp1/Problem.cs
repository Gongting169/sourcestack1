using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharplearn
{
    public class Problem : Content
    {
        //https://zhuanlan.zhihu.com/p/92362781
        //    观察“一起帮”的：
        //2、求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        //4、为这些类的字段和方法设置合适的访问修饰符。
        public  new string  Title { get; set; }
        public string _body { get; set; }
        public DateTime PublishDateTime { get; set; }
        public new  User Author { get; set; }
        // https://zhuanlan.zhihu.com/p/92470130 进一步封装里面的作业：
        //1、将之前User/Problem/HelpMoney类的字段封装成属性，其中：
        //problem.Reward不能为负数
        public int Reward
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("悬赏数不能为负数");
                    return;
                }
            }
            get { return Reward; }
        }
        //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        private string[] KeyWord = new string[10];
        public string this[int index]
        {
            get { return KeyWord[index - 1]; }
            set { KeyWord[index - 1] = value; }
        }
        //4、设计一种方式，保证：
        //每一个Problem对象一定有Body赋值
        public Problem(string body) : base("fg")
        {
            _body = body;
        }
        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
        //Publish()：发布一篇求助，并将其保存到数据库 实例：
        //Load(int Id)：根据Id从数据库获取一条求助  静态：
        //Delete(int Id)：根据Id删除某个求助       静态：
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等
        [HelpMoneyChanged(Amount = 1)]
        public void  Publish()
        {
           
        }
        public static void Load(int id)//根据Id从数据库获取一条求助
        {

        }
        public static void Delete(int id)//根据Id删除某个求助 
        {

        }

        //https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        public override void Release()
        {
            Console.WriteLine("需要消耗其设置悬赏数量的帮帮币");
        }

        //https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        public override void Agree()
        {
            Bangpoint++;
        }
        public override void Disagree()
        {
            Bangpoint--;
        }

    }

}


















