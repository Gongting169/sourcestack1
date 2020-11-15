using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.Generic
{
    public class Appraise
    {
        public string  name { get; set; }
        public int Agree { get; set; }
        public int Disagree { get; set; }

        public IList<Article> Articles { get; set; }
        public IList<GenericComment>  GenericComments { get; set; }
    }
}
