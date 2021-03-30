using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRV.ViewModel
{
    public class ArticleSingleModel
    {

        public string Title { get; set; }

        public string Body { get; set; }

        public string Category { get; set; }

        public string PublishTime { get; set; }

        public string ArticleId { get; set; }

        public string AuthorName { get; set; }

        #region 文章上一篇和下一篇
        public string PreArticleId { get; set; }

        public string NextArticleId { get; set; }

        public string PreArticleTitle { get; set; }

        public string NextArticleTitle { get; set; }
        #endregion


        public string CurrentUser { get; set; }

        public IList<CommentModel> Comments { get; set; }

        public  IList<AppraiseModel> Appraises { get; set;}

        public IList<KeywordModel> Keywords { get; set; }

    }
}