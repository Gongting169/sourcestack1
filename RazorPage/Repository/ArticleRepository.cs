using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace sourcestack1.Repository
{
    public class ArticleRepository
    {
        public int ArticlesCount = articles.Count;
        private static IList<Article> articles;
        static ArticleRepository()
        {
            UserRepository userRepository = new UserRepository();
            KeywordRepository keywordRepository = new KeywordRepository();
            CommentRepository commentRepository = new CommentRepository();
            articles = new List<Article>
            {
                new Article
                {
                Id= 1,
                Title=@"VS中的第一个页面",
                Body=@" 学习HTML，其实就是学习一系列的标记（markup），而标记的核心就是元素（element）HTML标记语言的核心就是元素。
            元素由标签、属性和文本内容组成，比如：&lt;h1 style=""color:red""	&gt;一起帮·源栈欢迎您！&lt;/h1&gt;其中：元素（element）
            ：整个这一行就是一个标签（tag）：h1，又分为开始标签（&lt; h1 & gt;）和结束 （&lt;/ h1 & gt;）标签文本（text）：一起帮·源栈欢迎您！
            ，放置在开始标签和结束标签之间 属性（attribute）：st",
                 Author = userRepository.Find(1),
                 PublishTime = new DateTime(2020,3,27,6,25,18),
                 //Keywords = keywordRepository.Find(1),
                 Comments = new List<Comment>(){ new Comment (){Content ="马保国"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Down},new Appraise(){ Direction =AppraiseDirection.Up} }
                },
                new Article
                {
                Id= 2,
                Title=@"Promise：回调地狱/then()/fulfiled/reject……",
                Body=@" 回调地狱在JavaScript中，异步通常就伴随着回调（复习：异步和回调）。为什么呢？看下面的代码：
                let result = false;function loadSuccess() {setTimeout(function () {result = true;}, 1000)}
                loadSuccess();console.log(result ? 'oh yeah!' : 'what happen?');@想一想@：结果是什么？
               （演示：并在控制台看一下result的值）如果我们想要保持loadSucces ……",
                 Author =  userRepository.Find(2),
                 PublishTime = new DateTime(2020,5,3,14,58,32),
                 Keywords = new List<Keyword>(){new Keyword(){Name="ES6"},new Keyword(){Name="promise"},new Keyword(){Name="回调地狱"} },
                 Comments = new List<Comment>(){ new Comment (){Content ="真不错"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise(){ Direction =AppraiseDirection.Down} }
                },
                new Article
                {
                 Id= 3,
                 Title=@"JQuery：表单/Ajax/其他…… ",
                 Body=@" 表单简写:<inputType> / :submit / :text ……prop()以及val()文本：text 和 textarea选择：
                 check 和 radio下拉列表：select常用：取值赋值：选中只读/禁用JQuery效果hide()/show()/toggle() 淡入淡出：fade...()
                 滑动：slide 自定义动画：animiate 其他方法 静态：$.trim()/$.isNumeric()/…….data(name)：取属性中data-name的值noConflic ……",
                 Author = userRepository.Find(4) ,
                 PublishTime = new DateTime(2020,6,7,9,25,8),
                 Keywords = new List<Keyword>(){new Keyword(){Name="JQuery"},new Keyword(){Name="AJax"},new Keyword(){Name="表单"} },
                 Comments = new List<Comment>(){ new Comment (){Content ="年轻人"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise() { Direction =AppraiseDirection.Down} }
                },
                new Article
                {
                Id= 4,
                Title=@"RazorPage：其他IActionResult：JsonResult",
                Body=@" 当JsonResult首先HttpMethod的返回值不能是void，可以是：public JsonResult OnGet() //推荐，
                可读性更高或者:public IActionResult OnGet()然后返回一个JsonResult实例即可：
                return new JsonResult(new{sname = ""阿泰"",age = 23,isMale = true,});
                 JsonSerializerOptions最新的ASP.NET core版本默认（仅测试也仅能）使用System.Tex ……",
                 Author =   userRepository.Find(3),
                 PublishTime = new DateTime(2019,8,5,6,1,35),
                 Keywords = new List<Keyword>(){new Keyword(){Name="Ajax"},new Keyword(){Name="Jison"},new Keyword(){Name="后台"} },
                 Comments = new List<Comment>(){ new Comment (){Content ="我草"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise() { Direction =AppraiseDirection.Down} }
                },
                new Article
                {
                Id= 5,
                Title=@"Bootstrap.js：引入/Modal/",
                Body=@" JS插件 引入bootstrap.js（基于jquery）复习：压缩.min 和 CDN第一个例子：Modaldata-js方法：modal()和option事件总结：
                （其他演示，略） dropdown和select的区别 ……",
                 Author = userRepository.Find(2),
                 PublishTime = new DateTime(2018,5,5,7,30,59),
                 Keywords = new List<Keyword>(){new Keyword(){Name="bootstrap.js"},new Keyword(){Name="插件"},new Keyword(){Name="入门"} },
                 Comments = new List<Comment>(){ new Comment (){Content ="你真香"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise() { Direction =AppraiseDirection.Down} }
                },
                new Article
                {
                Id= 6,
                Title=@"ES6和JS进阶：新的集合对象",
                Body=@" for...in或许是为了模拟其他语言（如C#的foreach），JavaScript推出了for...in循环，可以：遍历对象的全部属性for (var i in student) {console.log(i); 
                //想一想如何取到每个元素的值}或者数组的全部元素for (var n in numbers) {console.log(x); }但是，JavaScript自作聪明的“一心两用”却给我们带来一个意外惊喜：
                 numbers.name = 'Hello'; //数组仍然是一个对象，对 ",
                 Author = userRepository.Find(1),
                 PublishTime = new DateTime(2018,7,7,5,31,18),
                 Keywords = new List<Keyword>(){new Keyword(){Name="ES6"},new Keyword(){Name="集合"},new Keyword(){Name=""} },
                 Comments = new List<Comment>(){ new Comment (){Content ="闪电五连鞭"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise() { Direction =AppraiseDirection.Down} }
                },
                new Article
                {
                Id= 7,
                Title=@"Javascript的昨天今天和明天",
                Body=@" 生于仓促1995年，网景公司的Brendan Eich在两周之内设计出了JavaScript语言：所以JavaScript先天不足，缺陷很多。
                “有哪些bug用久了成了特性的例子？”Javascript里到处都是。和Java的关系？就北大青鸟和北大的关系一样 —— 完全没有关系，就是蹭Java的热点。
                又名ECMAScript：ECMA（European Computer Manufacturers Association）组织定制了JavaScript语言的标准。ES6已经在2015年6月正式发布，但浏览器 ……",
                 Author = userRepository.Find(1),
                 PublishTime = new DateTime(2020,6,1,7,21,30),
                 Keywords = new List<Keyword>(){new Keyword(){Name="JavaScript"},new Keyword(){Name="介绍"},new Keyword(){Name="历史"} },
                 Comments = new List<Comment>(){ new Comment (){Content ="马保国"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise() { Direction =AppraiseDirection.Down} }
                },
                new Article
                {
                Id= 8,
                Title=@"JavaScript：事件：冒泡和捕获机制",
                Body=@" 一般的事件处理不需要考虑这种情况。但是，这不仅是一个常见面试题，而且有其实际使用场景。演示准备 有父子两个元素<div id=""propagate""><p>源栈欢迎您+
                </p></div>为了便于演示，加上一点CSS效果：<style>#propagate {padding: 30px;border: 1px solid;}#propagate > p {background-color: blue;border: 1px dashed;}& ……",
                 Author = userRepository.Find(2),
                 PublishTime = new DateTime(2018,7,17,5,45,18),
                 Keywords = new List<Keyword>(){new Keyword(){Name="JavaScript"},new Keyword(){Name="事件"},new Keyword(){Name="冒泡"} },
                 Comments = new List<Comment>(){ new Comment (){Content ="马保国"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise() { Direction =AppraiseDirection.Down} }
                },
                new Article
                {
                Id= 9,
                Title=@"999天晚上聊一聊：检索目录：001-111",
                Body=@" 哪怕是行为艺术，我也要坚持999天！ 每天晚7点，欢迎围观。 ……",
                 Author = new User{Id =20,Name="大飞哥"},
                 PublishTime = new DateTime(2019,12,1,14,5,38),
                 Keywords = new List<Keyword>(){new Keyword(){Name="飞哥"},new Keyword(){Name="999天"},new Keyword(){Name="晚7点"} },
                 Comments = new List<Comment>(){ new Comment (){Content ="马保国"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise() { Direction =AppraiseDirection.Down} }
                },
                new Article
                {
                Id= 9,
                Title=@"NoSql：Memcached：get/set/delete……",
                Body=@" 关系型（SQL）数据库的特点特点实现适用于不适用于表结构建表时确定列规范格式数据（如：报表）异性（非规范结构）数据，扩展性不够，
                比如：爱好数据完整性范式、约束、事务……高标准要求正确性无需严格检查数据正确性高可查询性索引、丰富的SQL语句读大于写写大于读典型场景：
                汽车监控系统NoSQL运动大致经历一下三个阶段：关系型数据库一统江湖：关系型数据库=数据库No Sql：不再需要SQL 。背景：互联网尤其是Web2.0兴起，海量（低价值）数据生成，
                数据完整性要求降低，及时性要求增加。Not Only Sql：不",
                 Author = new User{Id =20,Name="大飞哥"},
                 PublishTime = new DateTime(2019,11,11,10,56,42),
                 Keywords = new List<Keyword>(){new Keyword(){Name="NoSql"},new Keyword(){Name="Memcache"},new Keyword(){Name=""} },
                 Comments = new List<Comment>(){ new Comment (){Content ="过年好"}},
                 Appraises = new List<Appraise>(){new Appraise (){Direction = AppraiseDirection.Up},new Appraise() { Direction =AppraiseDirection.Down} }
                }
            };
        }
        public Article Find(int id)
        {
            return articles.Where(a => a.Id == id).SingleOrDefault();

        }
        internal IList<Article> Get(int PageIndex, int PageSize)
        {
            return articles.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        }
        public void Delete()
        {

        }
        public void Save(Article article)
        {
            articles.Add(article);
        }

    }
}
