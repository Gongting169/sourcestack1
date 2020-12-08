using System;
using System.Collections.Generic;
using System.Text;

namespace SelfStudy
{
    class InstallOtherClass
    {
        //public Summary(string kind) : base(kind)
        //{
        //}
        ////https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        ////一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        //public User Observer { get; set; }
        //public int Bangpoint { get; set; }

        //public override void Agree()
        //{
        //    throw new NotImplementedException();
        //}

        //public override void Disagree()
        //{
        //    throw new NotImplementedException();
        //}


        ////https://zhuanlan.zhihu.com/p/92362781  基础中的类和对象里面的作业：
        ////    观察“一起帮”的：
        ////1、注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        ////4、为这些类的字段和方法设置合适的访问修饰符。
        //private User InvitedBy { get; set; }
        //public string verificationcode { get; set; }
        //public bool Register(User user)
        //{
        //    return true;
        //}
        //public bool LogIn(User user)
        //{
        //    if (user.verificationcode.Length != 4)
        //    {
        //        Console.WriteLine(" 验证码的长度只能等于4 ");
        //        return false;
        //    }
        //    if (user.verificationcode != "1235")
        //    {
        //        Console.WriteLine(" 验证码错误，请重新输入 ");
        //        return false;
        //    }
        //    if (user._name != "gty")
        //    {
        //        Console.WriteLine(" 用户名不存在 ");
        //        return false;
        //    }
        //    if (user._name.Length == 0)
        //    {
        //        Console.WriteLine(" 用户名不能为空  ");
        //        return false;
        //    }
        //    if (user._password.Length < 4 || user._password.Length > 20)
        //    {
        //        Console.WriteLine("密码的长度不能小于4，大于20");
        //        return false;
        //    }
        //    if (user._password.Length == 0)
        //    {
        //        Console.WriteLine(" 密码不能为空 ");
        //        return false;
        //    }
        //    if (user._name == "gty" && user._password == "1234" && user.verificationcode == "1235")
        //    {
        //        Console.WriteLine("恭喜！登录成功");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine();
        //        return false;
        //    }
        //}
        //// https://zhuanlan.zhihu.com/p/92470130 进一步封装里面的作业：
        ////1、将之前User/Problem/HelpMoney类的字段封装成属性，其中：
        ////user.Password在类的外部只能改不能读
        //private string _password;
        //internal string password
        //{
        //    set { _password = value; }
        //}
        ////如果user.Name为“admin”，输入时修改为“系统管理员”
        //private string _name;
        //public string Name
        //{
        //    set
        //    {
        //        if (value == "admin")
        //        {
        //            _name = "系统管理员";
        //        }
        //        else
        //        {
        //            _name = value;
        //        }
        //    }

        //    get { return _name; }
        //}
        ////4、设计一种方式，保证：
        ////每一个User对象一定有Name和Password赋值 
        //public User(string name, string password)
        //{
        //    _password = password;
        //    _name = name;
        //}
        ////https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        ////4、想一想，为什么Publish()方法不是放置在User类中呢？用户（user）发布（Publish）一篇文章（article），不正好是user.Publish(article) 么？

        ////https://zhuanlan.zhihu.com/p/93224519
        ////一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。假设User类同时继承了ISendMessage和IChat，如何处理？
        //void ISendMessage.Send()
        //{
        //    throw new NotImplementedException();
        //}
        //void IChat.Send()
        //{
        //    throw new NotImplementedException();
        //}
        ////https://zhuanlan.zhihu.com/p/94590467 不一样的权限管理：枚举和位运算的作业：
        ////3、User类中添加一个Tokens属性，类型为TokenManager
        //public TokenManager Tokens { get; set; }

        ////https://zhuanlan.zhihu.com/p/93747718 string还是stringBuilder里面的作业：
        ////设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。
        //public string Name1
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        if (value == "17bang" || value == "admin" || value == "管理员")
        //        {
        //            Console.WriteLine("输入信息错误，请重新输入");
        //            return;
        //        }
        //        else
        //        {
        //            _name = value;
        //        }
        //    }
        //}
        ////1、确保用户（User）的密码（Password）：
        ////长度不低于6
        ////必须由大小写英语字母、数字和特殊符号（~!@#$%^&*()_+）组成
        //public string Password
        //{
        //    set
        //    {
        //        if (value.Length < 6)
        //        {
        //            Console.WriteLine("密码长度必须大于6");
        //        }
        //        else if (GetUpper(value, "abcdefghijklmnopqrstuvwxyz", "0123456789", "（~!@#$%^&*()_+）", "ABCDEFGHIJKLMNOPQRSTUVWXYZ") == true)
        //        {
        //            Console.WriteLine("输入的密码正确：");
        //        }
        //        else
        //        {
        //            Console.WriteLine("请重新输入密码：");
        //        }
        //    }
        //    get { return _password; }
        //}
        //public bool GetUpper(string password, string lower, string number, string special, string upper)
        //{
        //    char[] ofa = password.ToCharArray();
        //    for (int i = 0; i < ofa.Length; i++)
        //    {
        //        if (lower.Contains(ofa[i]) && upper.Contains(ofa[i]) && special.Contains(ofa[i]) && number.Contains(ofa[i]))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public Suggest(string kind) : base("fg")
        //{
        //}
        ////https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        //public override void Release()
        //{
        //    Console.WriteLine("不需要帮帮币");
        //}
        ////https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        ////一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        //https://zhuanlan.zhihu.com/p/92362781
        //    观察“一起帮”的：
        //2、求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        //4、为这些类的字段和方法设置合适的访问修饰符。
        //public string Title { get; set; }
        //public string _body { get; set; }
        //public DateTime PublishDateTime { get; set; }
        //public new User Author { get; set; }
        //// https://zhuanlan.zhihu.com/p/92470130 进一步封装里面的作业：
        ////1、将之前User/Problem/HelpMoney类的字段封装成属性，其中：
        ////problem.Reward不能为负数
        //public new int Reward
        //{
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            Console.WriteLine("悬赏数不能为负数");
        //            return;
        //        }
        //    }
        //    get { return Reward; }
        //}
        ////3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        //private string[] KeyWord = new string[10];
        //public string this[int index]
        //{
        //    get { return KeyWord[index - 1]; }
        //    set { KeyWord[index - 1] = value; }
        //}
        ////4、设计一种方式，保证：
        ////每一个Problem对象一定有Body赋值
        //public Problem(string body) : base("fg")
        //{
        //    _body = body;
        //}
        ////https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        ////考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
        ////Publish()：发布一篇求助，并将其保存到数据库 实例：
        ////Load(int Id)：根据Id从数据库获取一条求助  静态：
        ////Delete(int Id)：根据Id删除某个求助       静态：
        ////repoistory：可用于在底层实现上述方法和数据库的连接操作等
        //[HelpMoneyChanged(Amount = 1)]
        //public void Publish()
        //{

        //}
        //public static void Load(int id)//根据Id从数据库获取一条求助
        //{

        //}
        //public static void Delete(int id)//根据Id删除某个求助 
        //{

        //}

        ////https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        //public override void Release()
        //{
        //    Console.WriteLine("需要消耗其设置悬赏数量的帮帮币");
        //}

        ////https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        ////一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        ///

        ////https://zhuanlan.zhihu.com/p/92535455 被多少人误解继承里面的作业：
        ////2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
        ////Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //protected string kind;
        ////确保每个Content对象都有kind的非空值
        //public Content(string kind)
        //{
        //    this.kind = kind;
        //}
        ////Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        ////其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
        //public User Author { get; set; }
        //public int Reward { get; set; }
        //public string Comment { get; set; }
        //public void Getcategory()
        //{
        //}
        ////https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        //public virtual void Release()
        //{
        //}
        ////https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        ////1、思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。是抽象类：抽象类里面是可以有字段、属性方法等
        ////一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        //public abstract void Agree();
        //public abstract void Disagree();
        ////https://zhuanlan.zhihu.com/p/93440022 面向对象：反射和特性里面的作业
        ////1、之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，想一想他们应该在哪里赋值比较好，并完成相应代码
        //public DateTime createTime { get; private set; }
        //public DateTime PublishTime { get; set; }
        //public Content(DateTime createTime, DateTime PublishTime)
        //{
        //    this.PublishTime = PublishTime;
        //    this.createTime = createTime;
        //}

        //public Article() : base("fg")
        //{
        //}
        ////https://zhuanlan.zhihu.com/p/93053223 你真的明白什么是多态吗?里面的作业：
        //public override void Release()
        //{
        //    Console.WriteLine("需要消耗一个帮帮币");
        //}

        ////https://zhuanlan.zhihu.com/p/93224519 抽象类还是接口里面的作业：
        ////一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        //public override void Agree()
        //{
        //    throw new NotImplementedException();
        //}

        //public override void Disagree()
        //{
        //    throw new NotImplementedException();
        //}
        ////https://zhuanlan.zhihu.com/p/93747718 string还是stringBuilder里面的作业：
        ////确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串；而且如果标题前后有空格，将空格予以删除
        //private string _Title;
        //public string Title
        //{
        //    get
        //    {
        //        return _Title;
        //    }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            Console.WriteLine("输入错误信息");
        //            return;
        //        }
        //        else
        //        {
        //            _Title = value.Trim();
        //        }
        //    }
        //}

        //分页自己写的模样：
        //        <nav aria-label="Page navigation example" style="margin-top:40px;margin-bottom:40px">
        //    <ul class="pagination">
        //        @if(Model.PageIndex != 1)
        //        {
        //            < li class="page-item">
        //                <a class="page-link" href="@Model.Path=@(Model.PageIndex-1)" aria-label="Next">
        //                    <span aria-hidden="true">&laquo;</span>
        //                </a>
        //            </li>
        //        }
        //    @if(string.IsNullOrWhiteSpace(Request.Query["PageIndex"]))
        //    {
        //            < li class="page-item ">
        //                <a href = "@Model.Path=1" ></ a >
        //            </ li >
        //        }
        //@if(Model.PageIndex <= 0)
        //        {
        //            < li class= "page-item " >
        //                 < a href = "@Model.Path=1" ></ a >
        //              </ li >
        //        }
        //        else
        //{
        //            < li class= "page-item " >
        //                 < a href = "@Model.Path=@(Model.PageIndex)" ></ a >
        //              </ li >
        //        }
        //        @if(Model.PageIndex > 1)
        //        {
        //            < li class= "page-item" >
        //                 < a class= "page-link" href = "@Model.Path=@(Model.PageIndex-1)" aria - label = "Previous" >
        //                         < span aria - hidden = "true" > &laquo;</ span >
        //                            </ a >
        //                        </ li >
        //        }
        //        else
        //{
        //            < li class= "page-item" >
        //                 < a href = "@Model.Path=1" ></ a >
        //              </ li >
        //        }
        //        @for(int i = 0; i < Model.ArticlelPageCounts; i++)
        //        {
        //    string active = Model.PageIndex == (i + 1) ? "active" : "null";
        //            < li class= "page-item @active" >
        //                 < a class= "page-link" href = "@Model.Path=@(i+1)" >@(i + 1) </ a >
        //                  </ li >
        //        }
        //        @if(Model.PageIndex < Model.ArticlelPageCounts)
        //        {
        //            < li class= "page-item" >
        //                 < a class= "page-link" href = "@Model.Path=@(Model.PageIndex+1)" aria - label = "Next" >
        //                         < span aria - hidden = "true" > &raquo;</ span >
        //                            </ a >
        //                        </ li >
        //        }
        //        else
        //{
        //            < li class= "page-item" >
        //                 < a href = "@Model.Path=@(Model.ArticlelPageCounts)" ></ a >
        //              </ li >
        //        }
        //        @if(Model.PageIndex != Model.ArticlelPageCounts - 1)
        //        {
        //            < li class= "page-item" >
       //                 < a href = "@Model.Path=@(Model.PageIndex+1)" aria - label = "Next" >
        //                    </ a >
        //                </ li >
        //        }
        //    </ ul >
        //</ nav >






































































































































































































    }
}
