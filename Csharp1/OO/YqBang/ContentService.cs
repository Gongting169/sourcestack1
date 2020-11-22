using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class ContentService
    {
        //https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        //1、添加一个新类ContentService，其中有一个发布（Publish()）方法：
        //如果发布Article，需要消耗一个帮帮币
        //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
        //如果发布Suggest，不需要消耗帮帮币
        //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine() 代替。根据我们学习的继承和多态知识，实现上述功能。
        [HelpMoneyChanged(Amount = 1)]
        public void Publish(Content content)
        {
            try
            {
                content.Publish();
            }
            catch (ArgumentNullException e)
            {
                throw new Exception("Id为{Id}的用户发布的文章的标题为{Title}内容的作者为空",e);
            }
            catch (ArgumentOutOfRangeException )
            {
                Console.WriteLine("Id为{Id}的用户发布的文章的标题为{Title}求助的Reward为负数");
            }
            finally
            {
                Console.WriteLine($"{ DateTime.Now.ToString("yyyy年MM月dd日 hh点mm分ss秒")} 请求发布内容(Id= xxx)");
            }
            Console.WriteLine("保存到数据库");
        }
        // 修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常
        //内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
        //在ContentService中捕获异常
        //如果是“参数为空”异常，Console.WriteLine()输出：内容的作者不能为空，将当前异常封装进新异常的InnerException，再将新异常抛出
        //如果是“”参数越界”异常，Console.WriteLine()输出：求助的Reward为负数（-XX），不再抛出异常
        //ContentService中无论是否捕获异常，均要Console.WriteLine()输出：XXXX年XX月XX日 XX点XX分XX秒（当前时间），请求发布内容（Id = XXX） 
        //在Main()函数调用ContentService时，捕获一切异常，并记录异常的消息和堆栈信息
        public User Author { get; set; }
        public string Content { get; set; }

    }
}
