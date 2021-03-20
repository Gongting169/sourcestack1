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
        public User Voter { get; set; }
        public AppraiseDirection Direction { get;  set; }

        //每个文章和评论都有一个评价
        public Article Article { get; set; }
        public Comment Comment { get; set; }
        public Suggest Suggest { get; set; }
        public void Agree()
        {
            Direction = AppraiseDirection.Up;
        }

        public void Disagree()
        {
            Direction = AppraiseDirection.Down;
        }
    }
}
