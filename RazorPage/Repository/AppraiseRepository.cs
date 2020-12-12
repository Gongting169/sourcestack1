using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class AppraiseRepository
    {
        private static IList<Appraise> appraises;
        static AppraiseRepository()
        {
            appraises = new List<Appraise>()
            {
                new Appraise (){ Direction =  AppraiseDirection.Down ,Id =1},
                new Appraise (){ Direction =  AppraiseDirection.Up   ,Id=2}
            };
        }
        public Appraise Find(int id)
        {
            return appraises.Where(a => a.Id == id).SingleOrDefault();
        }

        //private static IList<Article> articles;
        //static ArticleRepository()
        //{
        //    UserRepository userRepository = new UserRepository();
        //    KeywordRepository keywordRepository = new KeywordRepository();
        //    CommentRepository commentRepository = new CommentRepository();
        //    AppraiseRepository appraiseRepository = new AppraiseRepository();
        //    articles = new List<Article>
        //    {
        //        new Article
        //        {
        //        Id= 1,
        //        Title=@"VS中的第一个页面",
        //        Body=@" 学习HTML，其实就是学习一系列的标记（markup），而标记的核心就是元素（element）HTML标记语言的核心就是元素。
        //        元素由标签、属性和文本内容组成，比如：&lt;h1 style=""color:red""	&gt;一起帮·源栈欢迎您！&lt;/h1&gt;其中：元素（element）
        //        ：整个这一行就是一个标签（tag）：h1，又分为开始标签（&lt; h1 & gt;）和结束 （&lt;/ h1 & gt;）标签文本（text）：一起帮·源栈欢迎您！
        //        ，放置在开始标签和结束标签之间 属性（attribute）：st",
        //         Author = userRepository.Find(1),
        //         PublishTime = new DateTime(2020,3,27,6,25,18),
        //         Keywords = new List<Keyword>(){ keywordRepository.Find(1),keywordRepository.Find(3),keywordRepository.Find(5)},
        //         Comments = new List<Comment>(){commentRepository.Find(2),commentRepository.Find(10) },
        //         Appraises = new List<Appraise>(){appraiseRepository.Find(1),appraiseRepository.Find(2)}
        //        },
    }
}
