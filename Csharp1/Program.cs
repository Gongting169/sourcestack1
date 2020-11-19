
using CSharplearn;
using CSharplearn.ProcedureObject;
using CSharplearn.ProcedureObject.Enum;
using CSharplearn.ProcedureObject.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using static CSharplearn.ProcedureObject.Generic.Generic;

namespace CSharplearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            User fg = new User() { Name = "飞哥", Reward = 20 };
            User dfg = new User() { Name = "大飞哥", Reward = 30 };
            User xy = new User() { Name = "小鱼", Reward = 40 };
            IEnumerable<User> users = new List<User> { fg, dfg, xy };

            KeyWord csharp = new KeyWord() { Name = "Csharp" };
            KeyWord java = new KeyWord() { Name = "Java" };
            KeyWord js = new KeyWord() { Name = "js" };
            KeyWord keyWord = new KeyWord() { Name = "C#" };
            KeyWord keyWord1 = new KeyWord() { Name = ".Net" };
            IEnumerable<KeyWord> keyWords = new List<KeyWord> { keyWord, keyWord1, csharp, java, js };

            Article lgyarticle = new Article()
            { Title = "yqbang", Author = fg, PublishTime = new DateTime(2019, 1, 5), KeyWords = new List<KeyWord> { keyWord, csharp, js }, CommentCount = 10, };

            Article gtyarticle = new Article()
            { Title = "yz", Author = xy, PublishTime = new DateTime(2019, 6, 5), KeyWords = new List<KeyWord> { keyWord, keyWord1, java }, CommentCount = 30 };

            Article lwarticle = new Article()
            { Title = "web", Author = xy, PublishTime = new DateTime(2020, 5, 8), KeyWords = new List<KeyWord> { java, js, keyWord1 }, CommentCount = 50 };

            Article zdharticle = new Article()
            { Title = "C#", Author = dfg, PublishTime = new DateTime(2019, 3, 26), KeyWords = new List<KeyWord> { java, js, keyWord1 }, CommentCount = 20 };

            Article lzbarticle = new Article()
            { Title = ".Net", Author = xy, PublishTime = new DateTime(2020, 1, 1), KeyWords = new List<KeyWord> { java, js, keyWord1 }, CommentCount = 35 };

            IEnumerable<Article> articles = new List<Article> { lgyarticle, gtyarticle, lwarticle, zdharticle, lzbarticle };



            //在之前“文章 / 评价 / 评论 / 用户 / 关键字”对象模型的基础上，添加相应的数据，然后完成以下操作： 
            //找出“飞哥”发布的文章
            var result = from a in articles
                         where a.Author.Name == "飞哥"
                         select a;
            foreach (var item in result)
            {
                Console.WriteLine(item.Author);
            }
            //找出2019年1月1日以后“小鱼”发布的文章
            var result1 = from a in articles
                          where a.Author.Name == "小鱼"
                          where a.PublishTime > new DateTime(2019, 1, 1)
                          select a;
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }

            //按发布时间升序 / 降序排列显示文章
            var result2 = from a in articles
                          orderby a.PublishTime descending
                          select a;
            var result3 = from a in articles
                          orderby a.PublishTime
                          select a;
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            //统计每个用户各发布了多少篇文章
            var result4 = from a in articles
                          group a by a.User;

            //找出包含关键字“C#”或“.NET”的文章 
            //找出评论数量最多的文章
            //找出每个作者评论数最多的文章


            //方法 //给上述委托赋值，并运行该委托
            //Person person = new Person() { Age = 18, name = "龚廷义" };
            //ProvideWater provideWater = Add;
            //Console.WriteLine(provideWater(person));
            ////匿名方法 //给上述委托赋值 并运行该委托
            //ProvideWater provideWater1 = delegate (Person person)
            //{
            //    return person.Age++;
            //};
            //Console.WriteLine(provideWater1(person));
            ////lambda表达式  //给上述委托赋值  并运行该委托
            //ProvideWater provideWater2 = p => person.Age++;
            //Console.WriteLine(provideWater2(person));

            //ProvideWater provideWater3 = p => person.Age++;
            //Console.WriteLine(Generic.GetWater(provideWater3));

            //KeyWord Csharp = new KeyWord() { name = "Csharp" };
            //KeyWord Java = new KeyWord() { name = "Java" };
            //KeyWord js = new KeyWord() { name = "js" };

            //Article yqbang = new Article();
            //Article yz = new Article();
            //Comment<Article> comment1 = new Comment<Article>();
            //Appraise<Article> appraise = new Appraise<Article>();
            ////Appraise<Comment<Content>> appraise1 = new Appraise<Comment<Content>>();
            ////一篇文章可以有多个关键字，一个关键字可以对应多篇文章
            //yqbang.KeyWords = new List<KeyWord> { Csharp, Java, js };
            //yz.KeyWords = new List<KeyWord> { js, Java };

            //Csharp.Articles = new List<Article> { yqbang };
            //Java.Articles = new List<Article> { yqbang, yz };
            //js.Articles = new List<Article> { yqbang, yz };
            ////一个评论必须有一个它所评论的文章 
            ////一篇文章可以有多个评论
            //yqbang.Comments = new List<Comment<Article>> { comment1 };
            ////yqbang.Comments.Add(comment1); //两种都可以
            //comment1.Article = yqbang;
            ////每个文章和评论都有一个评价
            //yqbang.Appraises.Add(appraise);
            //appraise.Article = yqbang;
            //comment1.Appraises.Add(appraise);
            //appraise.Comment = comment1;
            //调用泛型改造的二分查找，最大值，栈
            //Generic generic = new Generic();
            //Console.WriteLine(generic.GetMax<int>(new int[] { 15, 23, 39, 65, 78, 2, 36, 7 }, 0));
            //Console.WriteLine(generic.GetMax<string>(new string[] { "李四往", "23", "39", "65", "78", "2", "36", "张三李四" }, "张三"));
            //Console.WriteLine(Generic.Getnumber<int>(new int[] { 2, 17, 26, 35, 48, 59, 61, 96 }, 96));
            //https://zhuanlan.zhihu.com/p/93747718 string还是stringBuilder里面的作业：调用
            //Console.WriteLine(Stringbuilder.GetCount("ashjbvjbkvhaihiwqifbkafkvjzbha", "a"));
            //Console.WriteLine(Stringbuilder.mimicJoin("-", new string[] { "a", "b", "c", "d" }));
            //https://zhuanlan.zhihu.com/p/93458057 万物皆对象：Object拆箱和装箱里面的作业：
            //在https://source.dot.net/中查看源代码，了解为什么 Console.WriteLine(new Student()); 会输出Student类名//static Equal () 方法 判断两个对象相不相等
            //思考dynamic和var的区别，并用代码予以演示
            //int a = 18;
            //string b = "fg";
            //var c = a;
            //var d = b;
            ////Console.WriteLine(c -d );
            //dynamic gty = "yz";
            //Console.WriteLine(gty -23);//dynamic会避开编译时的检查，但运行时会报错。var不行
            //构造一个能装任何数据的数组，并完成数据的读写
            //dynamic[] dfg = new dynamic[] { 23, "fg", true, false, 85.96 };
            //for (int i = 0; i < dfg.Length; i++)
            //{
            //    Console.WriteLine(dfg[i]);
            //}
            //https://zhuanlan.zhihu.com/p/93440022 面向对象：反射和特性里面的作业
            //4、用反射获取Publish()上的特性实例，输出其中包含的信息
            //Attribute attribute1 = HelpMoneyChangedAttribute.GetCustomAttribute
            //  (typeof(ContentService).GetMethod("Publish", BindingFlags.Public | BindingFlags.Instance)
            //  , typeof(HelpMoneyChangedAttribute));

            //Attribute attribute2 = HelpMoneyChangedAttribute.GetCustomAttribute
            //    (typeof(Problem).GetMethod("Publish", BindingFlags.Public | BindingFlags.Instance)
            //    , typeof(HelpMoneyChangedAttribute));

            //Console.WriteLine(((HelpMoneyChangedAttribute)attribute1).Amount);
            //Console.WriteLine(((HelpMoneyChangedAttribute)attribute2).Amount);
            //https://zhuanlan.zhihu.com/p/93440022 面向对象：反射和特性里面的作业
            //面向对象：反射和特性里面作业的调用：
            //Content content = new Suggest("zl");//仅是为了调用content变量中的createtime和publishtime
            //ContentCreateTime contentCreateTime = new ContentCreateTime();
            //contentCreateTime.ChangeTime(content, new DateTime(2020, 9, 1), new DateTime(2019, 8, 27));
            //Console.WriteLine(content.createTime);
            //Console.WriteLine(content.PublishTime);
            //https://zhuanlan.zhihu.com/p/94590192
            //面向对象：结构和日期里面的作业：
            //1、用代码证明struct定义的类型是值类型
            //Console.WriteLine(Prove.j);
            ////2、Getdate()的调用：
            //DateTime date = new DateTime(2019, 1, 8);
            //Prove prove = new Prove();
            //Console.WriteLine(prove.GetDate(date, 8, Unit.week));
            //https://zhuanlan.zhihu.com/p/94590467 不一样的权限管理：枚举和位运算的作业：
            //2、声明一个令牌管理（TokenManager）类：
            //使用私有的Token枚举_tokens存储所具有的权限
            //User gty = new User("12", "35");
            //gty.Tokens = new TokenManager();
            //gty.Tokens.Add(Token.Admin);
            //gty.Tokens.Add(Token.Blogger);
            //gty.Tokens.Remove(Token.Admin);
            //Console.WriteLine(gty.Tokens._tokens);

            //http://17bang.ren/Article/299
            //调用函数的作业：
            //作业：方法基础： 声明/调用/返回值
            //第1小题的调用：
            //Console.WriteLine(GetSum(1)); 
            //if (LogOnyqbang("ut91", "yezi", "1234", out string reason))
            //{
            //    Console.WriteLine(reason);
            //}
            //else
            //{
            //    Console.WriteLine(reason);
            //}
            //double[] score = { 76.52, 68.76, 99.6, 85.9, 65.8, 48.5, 100.3 };
            //Console.WriteLine( GetMax(score));
            //Console.WriteLine(GetMin(score ));
            //快速排序的调用：
            //int[] src = { 35, 2, 16, 52, 36, 15, 3, 4, 37, 53, 49 };
            //quickSort(src, 0, 10);
            //QuickSort(src, 0, src.Length - 1);
            //for (int i = 0; i < src.Length; i++)
            //{
            //    Console.WriteLine(src[i]);
            //}

            //第2小题的调用：
            //double[] score = { 76.52, 68.76, 99.6, 85.9, 65.8, 48.5 };
            ////Console.WriteLine(GetAverage(score));
            //http://17bang.ren/Article/303
            //作业：C#面向过程：方法进阶：值/引用传递。
            //第1小题的调用：
            //int bednumber1 = 202, bednumber2 = 203;
            //Swap(ref bednumber1, ref bednumber2);
            ////第2小题的调用：
            //if (LogOn("ut91","yezi","1234",out string reason))
            //{
            //    Console.WriteLine(reason);
            //}
            //else
            //{
            //    Console.WriteLine(reason);
            //}


        }
    }
}


