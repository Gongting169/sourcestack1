using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.Generic
{
    public class Comment
    {
        public string name { get; set; }

        public Article Article { get; set; }

        public IList<Appraise> Appraises { get; set; }
    }
}
