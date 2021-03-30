using BLL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Appraise : Entity
    {
        //一篇文章可以有多个评论
        //一个评论必须有一个它所评论的文章
        //每个文章和评论都有一个评价
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public virtual User Voter { get; set; }

        public AppraiseDirection DirectionUp { get; set; }

        public AppraiseDirection DirectionDown { get; set; }
        #region 每个文章所对应评价的点赞和点踩
        public int UpCount { get; set; }

        public int DownCount { get; set; }

        public virtual Article Article { get; set; }
        #endregion

        #region 每个评论所对应的评价支持和反对
        public int SupportCount { get; set; }

        public int OpposeCount { get; set; }

        public virtual Comment Comment { get; set; }
        #endregion

        public Suggest Suggest { get; set; }

    }
}
