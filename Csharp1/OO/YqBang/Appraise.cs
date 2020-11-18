using CSharplearn.OO.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.Generic
{
    public class Appraise<T> where T : Content
    {
        public T Target { get; set; }
        public User Voter { get; set; }
        public AppraiseDirection Direction { get; private set; }

        //每个文章和评论都有一个评价
        public T Article { get; set; }
        public Comment<T> Comment { get; set; }

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
