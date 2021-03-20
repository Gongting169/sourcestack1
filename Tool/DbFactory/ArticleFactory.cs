using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class ArticleFactory
    {

        internal static Article consoleProgram, variable, express, method, branch, array,
            xunHuan, jinJie, parameter, yuanZu;
        internal static void Create()
        {
            consoleProgram = Generate1("C#：控制台项目");
            variable = Generate2("C#：面向过程：变量和类型");
            express = Generate3("C#：面向过程：运算符和表达式");
            method = Generate4("C#面向过程：方法基础：声明/调用/返回值");
            branch = Generate5("C#：面向过程：分支：if...else");
            array = Generate6("C#：面向过程：数组");
            xunHuan = Generate7("C#：面向过程：循环");
            jinJie = Generate8("C#：面向过程：方法进阶：值/引用传递");
            parameter = Generate9("C#：面向过程：方法进阶：参数：重载/可选/params");
            yuanZu = Generate10("C#：面向过程：元组");
        }
        /// <summary>
        /// 文章控制台项目consoleProgram
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate1(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.LiSi;
            article.Body = Read("ConsoleProgram");
            article.PublishTime = Content.SetPublishTime(new DateTime(2020,1,23,14,23,36));
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.csharp, KeywordFactory.java, KeywordFactory.js };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aConsoleProgram };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// 文章C#：面向过程：变量和类型variable
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate2(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.WangWu;
            article.Body = Read("VariableType");
            article.PublishTime = Helper.baseLine.AddDays(2);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.css, KeywordFactory.linux, KeywordFactory.sql };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aBianLiang };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// 文章C#运算符和表达式express
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate3(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.XiaoWei;
            article.Body = Read("Express");
            article.PublishTime = Helper.baseLine.AddDays(3);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.css, KeywordFactory.linux, KeywordFactory.sql };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aExpress };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// C#面向过程：方法基础：声明/调用/返回值method
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate4(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.ZhangSan;
            article.Body = Read("Method");
            article.PublishTime = Helper.baseLine.AddDays(4);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.css, KeywordFactory.linux, KeywordFactory.sql };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aMethodDefine };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// 文章C#：面向过程：分支：if...elsebranch
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate5(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.WangWu;
            article.Body = Read("Branch");
            article.PublishTime = Helper.baseLine.AddDays(5);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.csharp, KeywordFactory.java, KeywordFactory.js };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aBranch };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// 文章C#：面向过程：数组 array
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate6(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.ZhangSan;
            article.Body = Read("Array");
            article.PublishTime = Helper.baseLine.AddDays(6);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.csharp, KeywordFactory.java, KeywordFactory.js };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aArray };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// 文章C#：面向过程：循环xunHuan
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate7(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.XiaoWei;
            article.Body = Read("XunHuan");
            article.PublishTime = Helper.baseLine.AddDays(7);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.css, KeywordFactory.linux, KeywordFactory.sql };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aXunHuan };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// 文章 jinJie"C#：面向过程：方法进阶：值/引用传递
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate8(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.LiSi;
            article.Body = Read("Jinjie");
            article.PublishTime = Helper.baseLine.AddDays(8);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.css, KeywordFactory.linux, KeywordFactory.sql };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aMethodJinjie };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// 文章 C#：面向过程：方法进阶：参数：重载/可选/paramsparameter
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate9(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.WangWu;
            article.Body = Read("Parameter");
            article.PublishTime = Helper.baseLine.AddDays(9);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.css, KeywordFactory.linux, KeywordFactory.sql };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aParameter };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }
        /// <summary>
        /// 文章 C#：面向过程：元组 yuanZu
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private static Article Generate10(string title)
        {
            Article article = new Article();
            article.Author = UserFactory.XiaoWei;
            article.Body = Read("YuanZu");
            article.PublishTime = Helper.baseLine.AddDays(10);
            article.Title = title;
            article.KeyWords = new List<Keyword>() { KeywordFactory.css, KeywordFactory.linux, KeywordFactory.sql };
            article.Comments = new List<Comment>() { };
            article.Appraises = new List<Appraise>() { AppraiseFactory.aYuanZu };
            new ArticleRepository(Helper.GetDbContext()).Save(article);
            return article;
        }

        private static string Read(string name)
        {
            string path = Environment.CurrentDirectory.Replace("\\bin\\Debug", string.Empty);
            return File.ReadAllText(Path.Combine(path, "Articles", $"{name}.txt"));
        }
    }
}
