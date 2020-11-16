using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.Generic
{
    public class Comment<T> where T: Content
    {
        public string Content{ get; set; }
        public T Article { get; set; }
        public IList<Appraise<T>> Appraises { get; set; }
    }
}
