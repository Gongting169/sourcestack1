using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRV.ViewModel 
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishTime { get; set; }
        public  UserModel Author { get; set; }
        public IList<KeywordModel> keywords { get; set; }
        public IList<CommentModel> Comments { get; set; }
        public IList<AppraiseModel> Appraises { get; set; }
    }
}