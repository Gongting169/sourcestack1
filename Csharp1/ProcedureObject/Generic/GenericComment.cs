using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.Generic
{
    public class GenericComment
    {
        public string name { get; set; }

        public Article Article { get; set; }

        public IList<Appraise> Appraises { get; set; }
    }
}
