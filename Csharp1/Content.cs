using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public abstract class Content : Entity<int>
    {
        //https://zhuanlan.zhihu.com/p/92535455 被多少人误解继承里面的作业：
        //2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        protected string kind;
        //确保每个Content对象都有kind的非空值
        public Content(string kind)
        {
            this.kind = kind;
        }
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
        public User Author { get; set; }
        public int Reward { get; set; }
        public string Comment { get; set; }
        public void Getcategory()
        {

        }
        //https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        public virtual void Release()
        {

        }
        //https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        //1、思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。是抽象类：抽象类里面是可以有字段、属性方法等
        //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        public abstract void Agree();
        public abstract void Disagree();
        public User Observer { get; set; }
        public int Bangpoint { get; set; }

        //https://zhuanlan.zhihu.com/p/93440022 面向对象：反射和特性里面的作业
        //1、之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，想一想他们应该在哪里赋值比较好，并完成相应代码
        public  DateTime createTime { get; private set; }
        public DateTime PublishTime { get; set; }
        public Content(DateTime createTime, DateTime PublishTime)
        {
            this.PublishTime = PublishTime;
            this.createTime = createTime;
        }

    }
}
