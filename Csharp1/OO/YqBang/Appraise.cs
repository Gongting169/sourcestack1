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
        public User DoneBy { get; set; }
        public T Article { get; set; }
        public Comment<T> Comment { get; set; }


    }
}
