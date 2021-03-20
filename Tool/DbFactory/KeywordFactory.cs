using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class KeywordFactory
    {

        internal static Keyword csharp, java, css, sql, linux, net, html, vs, js;
        internal static void Creat()
        {
            csharp = Generate("Csharp");
            java = Generate("JAVA");
            js = Generate("JavaScript");

            css = GenerateSecond("Css");
            sql = GenerateSecond("SQL");
            linux = GenerateSecond("Linux");

            net = GenerateThird("·NeT");
            html = GenerateThird("Html");
            vs = GenerateThird("VisualStudio");

        }

        private static Keyword Generate(string name)
        {
            Keyword keyword = new Keyword();
            keyword.Name = name;
            keyword.Used = new Random().Next(10);
            keyword.Articles = new List<Article>() { ArticleFactory.array, ArticleFactory.branch, ArticleFactory.consoleProgram };
            new KeywordRepository(Helper.GetDbContext()).Save(keyword);
            return keyword;

        }

        private static Keyword GenerateSecond(string name)
        {
            Keyword keyword = new Keyword();
            keyword.Name = name;
            keyword.Used = new Random().Next(10);
            keyword.Articles = new List<Article>() { ArticleFactory.express, ArticleFactory.jinJie, ArticleFactory.method };
            new KeywordRepository(Helper.GetDbContext()).Save(keyword);
            return keyword;
        }

        private static Keyword GenerateThird(string name)
        {
            Keyword keyword = new Keyword();
            keyword.Name = name;
            keyword.Used = new Random().Next(10);
            keyword.Articles = new List<Article>() { ArticleFactory.parameter, ArticleFactory.variable, ArticleFactory.xunHuan, ArticleFactory.yuanZu };
            new KeywordRepository(Helper.GetDbContext()).Save(keyword);
            return keyword;
        }





    }
}
