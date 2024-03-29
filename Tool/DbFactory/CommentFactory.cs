﻿using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class CommentFactory
    {
        internal static Comment branch;

        internal static void Create()
        {
            branch = Generate(new List<Appraise>() { AppraiseFactory.aBranch }, ArticleFactory.branch,
                UserFactory.ZhangSan, "明天真好", DateTime.Now, null);
        }
        private static Comment Generate(IList<Appraise> appraise, Article article, User user, string body, DateTime publishTime, Comment reply)
        {
            Comment comment = new Comment();
            comment.Article = article;
            comment.Author = user;
            comment.Body = body;
            comment.Appraises = appraise;
            comment.PublishTime = publishTime;
            comment.Reply = reply;
            //comment.ReplyId = 5;
            new CommentRepository(Helper.GetDbContext()).Save(comment);
            return comment;
        }







    }
}
