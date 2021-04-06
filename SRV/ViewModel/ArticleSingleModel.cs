using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRV.ViewModel
{
    public class ArticleSingleModel : BaseModel
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Category { get; set; }

        public DateTime PublishTime { get; set; }

        public UserModel Author { get; set; }

        public int  CommentCount { get; set; }//算谁的职责？

        [AllowHtml]
        [Required(ErrorMessage = "* 评论的内容不能为空")]
        public string EditorBody { get; set; }

        #region 文章上一篇和下一篇
        public int PreArticleId { get; set; }

        public int NextArticleId { get; set; }

        public string PreArticleTitle { get; set; }

        public string NextArticleTitle { get; set; }
        #endregion

        public IList<CommentModel> Comments { get; set; }

        public IList<AppraiseModel> Appraises { get; set; }

        public IList<KeywordModel> Keywords { get; set; }

    }
}