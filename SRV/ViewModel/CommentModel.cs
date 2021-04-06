using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SRV.ViewModel
{
    public class CommentModel : BaseModel
    {
        [AllowHtml]
        [Required(ErrorMessage = "* 评论的内容不能为空")]
        public string EditorBody { get; set; }

        public int Id { get; set; }

        public string Direction { get; set; }

        public string Body { get; set; }

        public CommentModel Reply { get; set; }

        public DateTime PublishTime { get; set; }

        public UserModel Author { get; set; }

        public ArticleSingleModel ArticleSingleModel { get; set; }

        public IList<AppraiseModel> Appraises { get; set; }
    }
}
