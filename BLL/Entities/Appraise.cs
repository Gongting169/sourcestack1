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
        public virtual User Voter { get; set; }
        public AppraiseDirection DirectionUp { get; set; }
        public AppraiseDirection DirectionDown { get; set; }
        public int UpCount { get; set; }
        public int DownCount { get; set; }
        //每个文章和评论都有一个评价
        public virtual Article Article { get; set; }
        public virtual Comment Comment { get; set; }
        public Suggest Suggest { get; set; }
    }
}
