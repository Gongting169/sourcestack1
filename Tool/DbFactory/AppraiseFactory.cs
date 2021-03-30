using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities.Enum;
using BLL.Repositories;

namespace DbFactory
{
    public class AppraiseFactory
    {
        internal static Appraise aArray, aBranch, aParameter, aExpress, aJinjie,
            aMethodJinjie, aConsoleProgram, aBianLiang, aXunHuan, aYuanZu, aMethodDefine;
        internal static void Create()
        {
            aArray = Generate();
            aBranch = Generate1();
            aParameter = Generate10();
            aExpress = Generate2();
            aJinjie = Generate3();
            aMethodJinjie = Generate4();
            aConsoleProgram = Generate5();
            aBianLiang = Generate6();
            aXunHuan = Generate7();
            aYuanZu = Generate8();
            aMethodDefine = Generate9();

        }
        /// <summary>
        /// 用户李四对数组进行了点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.LiSi;
            appraise.Article = ArticleFactory.array;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户王五对文章分支进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate1()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.WangWu;
            appraise.Article = ArticleFactory.branch;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            appraise.Comment = CommentFactory.branch;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户小伟对文章表达式进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate2()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.XiaoWei;
            appraise.Article = ArticleFactory.express;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户张三对文章C#进阶进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate3()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.ZhangSan;
            appraise.Article = ArticleFactory.jinJie;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户李四对文章方法进阶进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate4()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.LiSi;
            appraise.Article = ArticleFactory.method;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户王五对文章控制台项目进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate5()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.WangWu;
            appraise.Article = ArticleFactory.consoleProgram;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户小伟对文章变量类型进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate6()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.XiaoWei;
            appraise.Article = ArticleFactory.variable;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户张三对文章循环进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate7()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.ZhangSan;
            appraise.Article = ArticleFactory.xunHuan;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户李四对文章元祖进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate8()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.LiSi;
            appraise.Article = ArticleFactory.yuanZu;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户王五对文章方法定义进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate9()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.WangWu;
            appraise.Article = ArticleFactory.method;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }

        /// <summary>
        /// 用户小伟对文章参数进行点赞和点踩
        /// </summary>
        /// <returns></returns>
        private static Appraise Generate10()
        {
            Appraise appraise = new Appraise();
            appraise.Voter = UserFactory.XiaoWei;
            appraise.Article = ArticleFactory.parameter;
            appraise.DirectionDown = AppraiseDirection.Down;
            appraise.DirectionUp = AppraiseDirection.Up;
            appraise.UpCount = 1;
            appraise.DownCount = 1;
            new AppraiseRepository(Helper.GetDbContext()).Save(appraise);
            return appraise;
        }



    }
}
