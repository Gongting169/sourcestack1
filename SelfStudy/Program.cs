using System;

namespace SelfStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组的冒泡排序；
            //int[] sort = { 132, 35, 26, 3, 18, 22, 16, 45, 53, 62, 7 };
            //        for (int i = 1; i < sort.Length; i++)  // 第二轮查找
            //        {
            //            for (int j = 0; j < sort.Length - i; j++) // 第一轮查找
            //            {
            //                if (sort[j] > sort[j + 1])
            //                {
            //                   int  temp = sort[j];
            //                    sort[j] = sort[j + 1];
            //                    sort[j + 1] = temp; 
            //                }
            //            }
            //        }
            //为什么要在外面套一层for循环：因为第一轮查找是进行第一轮排序，如果在里面套for循环的话，如果没有包含住if条件语句，没有达到排序的目的，只是进行了循环，所以这是不行的
            //如果在里面嵌套一层for循环包含住if条件语句，就是进行第二轮循环，操作起来稍微麻烦一点没有必要申明多的变量（变量可以省，不会有太大的用处，可有可无）
            //前面的树大于后面的数就可以直接得出结果。外循环的次数不变，但内循环的次数-i，减少的是内循环查找完几次，外循环就减少几次查找。   
            //生成一个元素（值随机）从小到大排列的数组
            //int[] nums = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = random.Next(0, 100);
            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = i + 1; j < 10; j++)
            //    {
            //        if (nums[j] < nums[i])
            //        {
            //            int temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //}
            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.Read();

            //TokenManager tokenManager = new TokenManager();
            //Token token = new Token();
            //Console.WriteLine(tokenManager.T.Add(Token.Admin));
            //Article lw = new Article();
            //lw.AgreeBy(new User("ss", "ss"));

            ////User lw = new User("1230", "ss");
            ////lw.Tokens = new TokenManager();
            ////lw.Tokens.Add(Token.Admin);
            ////lw.Tokens.Add(Token.Blogger);
            ////lw.Tokens.Remove(Token.Admin);
            ////lw.Tokens.Remove(Token.Registered);

            ////Console.WriteLine(lw.Tokens.Tokens);

            ////MimicStack lw = new MimicStack(20);
            ////User abc = new User("jkl", "sss");
            ////lw.Push(abc);
            ////User u = (User)lw.Pop();
            ////Console.WriteLine(u.Name);
            //DateTimeManager tm = new DateTimeManager();

            //tm.WeekOfYear(2020);

            //DateTime dt = new DateTime(2020, 2, 1);

            //Console.WriteLine(tm.GetDate(dt, 29, Time.Day));

            //Console.WriteLine(DateTime.Now.DayOfWeek);
            //Console.WriteLine(new DateTime(2020 / 10 / 29).DayOfWeek);

            //4、将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] score = { 76.52, 68.76, 99.6, 85.9, 65.8, 48.5, 100.52 };
            //double max = score[0];
            //for (int i = 1; i < score.Length; i++) // 用循环找最高分
            //{
            //    if (score[i] > max)
            //    {
            //        max = score[i];
            //    }// else continue
            //}
            //Console.WriteLine(max);
            //double min = score[0];
            //for (int i = 1; i < score.Length; i++) // 循环找最低分
            //{
            //    if (score[i] < min)
            //    {
            //        min = score[i];
            //    }// else continue
            //}
            //Console.WriteLine(min);


            foreach (Student item in new Student())
            {
                Console.WriteLine(item.name);
            }


            //ContentService fb = new ContentService();

            //ContentDateTime alter = new ContentDateTime();


            //Article lwarticle = new Article() { Title = "刘伟好帅", Body = "我是刘伟就是帅", Author = lw };
            //fb.Publish(lwarticle);
            //alter.AlterPublishTime(lwarticle, new DateTime(2018, 2, 3));

            //Article xyarticle = new Article() { Title = "C#", Body = "我是小鱼C#", Author = xy };
            //fb.Publish(xyarticle);
            //alter.AlterPublishTime(xyarticle, new DateTime(2020, 7, 18));

            //Article fgarticle = new Article() { Title = ".NET", Body = "我是飞哥,NET", Author = fg };
            //fb.Publish(fgarticle);
            //alter.AlterPublishTime(fgarticle, new DateTime(2014, 6, 3));

            //Article zlarticle = new Article() { Title = "C#", Body = "我是邹丽C#", Author = zl };
            //fb.Publish(zlarticle);
            //alter.AlterPublishTime(zlarticle, new DateTime(2012, 7, 6));

            //Article fgarticle2 = new Article() { Title = ".NET", Body = "我是飞哥2.NET", Author = fg };
            //fb.Publish(fgarticle2);
            //alter.AlterPublishTime(fgarticle2, new DateTime(2008, 8, 9));

            //Article xyarticle2 = new Article() { Title = "", Body = "我是小鱼 小鱼儿", Author = xy };
            //fb.Publish(xyarticle2);
            //alter.AlterPublishTime(xyarticle2, new DateTime(2010, 12, 23));

            //Article fgarticle3 = new Article() { Title = "C#", Body = "我是飞哥3.C#", Author = fg };
            //fb.Publish(fgarticle3);
            //alter.AlterPublishTime(fgarticle3, new DateTime(2018, 8, 13));

            //Article fgarticle4 = new Article() { Title = "飞哥好帅", Body = "我是飞哥就是帅", Author = fg };
            //fb.Publish(fgarticle4);


            //IList<Article> articles = new List<Article>();
            //articles.Add(lwarticle);
            //articles.Add(xyarticle);
            //articles.Add(fgarticle);
            //articles.Add(zlarticle);
            //articles.Add(fgarticle2);
            //articles.Add(xyarticle2);
            //articles.Add(fgarticle3);
            //articles.Add(fgarticle4);


            //Appraise<Article> zlappraise = new Appraise<Article>() { Author = zl };
            //zlappraise.DisAgree(lwarticle);

            //lwarticle.AppraiseS = new List<Appraise<Article>>();
            //lwarticle.AppraiseS.Add(zlappraise);

            //Appraise<Article> xyappraise = new Appraise<Article>() { Author = xy };
            //xyappraise.Agree(fgarticle);

            //fgarticle.AppraiseS = new List<Appraise<Article>>();
            //fgarticle.AppraiseS.Add(xyappraise);

            //Appraise<Article> fgappraise = new Appraise<Article>() { Author = fg };
            //fgappraise.DisAgree(xyarticle);

            //xyarticle.AppraiseS = new List<Appraise<Article>>();
            //xyarticle.AppraiseS.Add(fgappraise);

            //Appraise<Article> lwappraise = new Appraise<Article>() { Author = lw };
            //lwappraise.Agree(fgarticle);
            //fgarticle.AppraiseS.Add(lwappraise);

            //Appraise<Article> lgyappraise = new Appraise<Article>() { Author = lgy };
            //lgyappraise.Agree(xyarticle);
            //xyarticle.AppraiseS.Add(lgyappraise);

            //Appraise<Article> gtyappraise = new Appraise<Article>() { Author = gty };
            //gtyappraise.DisAgree(fgarticle);
            //fgarticle.AppraiseS.Add(gtyappraise);

            //Comment<Article> lwcomment = new Comment<Article>() { Author = lw, Body = "写得好,我是刘伟" };
            //Comment<Article> gtycomment = new Comment<Article>() { Author = gty, Body = "写得好，我是龚廷义" };
            //Comment<Article> lgycomment = new Comment<Article>() { Author = lgy, Body = "写得好，写得好我是廖光银" };
            //Comment<Article> zlycomment = new Comment<Article>() { Author = zl, Body = "写得好，写得好我是邹丽" };



            //fgarticle.Comments = new List<Comment<Article>>();
            //fgarticle.Comments.Add(lwcomment);
            //fgarticle.Comments.Add(gtycomment);
            //fgarticle.Comments.Add(zlycomment);


            //xyarticle.Comments = new List<Comment<Article>>();
            //xyarticle.Comments.Add(lgycomment);
            //xyarticle.Comments.Add(zlycomment);

            //lwarticle.Comments = new List<Comment<Article>>();
            //lwarticle.Comments.Add(zlycomment);

            //zlarticle.Comments = new List<Comment<Article>>();
            //zlarticle.Comments.Add(lwcomment);

            //xyarticle2.Comments = new List<Comment<Article>>();
            //xyarticle2.Comments.Add(lwcomment);

            //fgarticle2.Comments = new List<Comment<Article>>();
            //fgarticle2.Comments.Add(zlycomment);

            //fgarticle3.Comments = new List<Comment<Article>>();
            //fgarticle3.Comments.Add(zlycomment);

            //fgarticle4.Comments = new List<Comment<Article>>();
            //fgarticle4.Comments.Add(lwcomment);


            //Keyword<Article> k1 = new Keyword<Article>() { Word = "C#" };
            //Keyword<Article> k2 = new Keyword<Article>() { Word = ".NET" };
            //Keyword<Article> k3 = new Keyword<Article>() { Word = "66666" };


            //lwarticle.Keywords = new List<Keyword<Article>>();
            //xyarticle.Keywords = new List<Keyword<Article>>();
            //zlarticle.Keywords = new List<Keyword<Article>>();
            //fgarticle.Keywords = new List<Keyword<Article>>();

            //xyarticle2.Keywords = new List<Keyword<Article>>();
            //fgarticle2.Keywords = new List<Keyword<Article>>();
            //fgarticle3.Keywords = new List<Keyword<Article>>();
            //fgarticle4.Keywords = new List<Keyword<Article>>();

            //lwarticle.Keywords.Add(k3);
            //zlarticle.Keywords.Add(k1);
            //xyarticle.Keywords.Add(k1);
            //fgarticle.Keywords.Add(k2);
            //xyarticle2.Keywords.Add(k2);
            //fgarticle3.Keywords.Add(k1);
            //fgarticle4.Keywords.Add(k3);

        }
    }
}

