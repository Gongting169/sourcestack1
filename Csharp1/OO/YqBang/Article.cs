using CSharplearn.ProcedureObject.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class Article : Content
    {
        public IList<Comment<Article>> Comments { get; set; }
        public IList<KeyWord> KeyWords { get; set; }
        public IList<Appraise<Article>> Appraises { get; set; }
        public int Agreed { get; set; }
        public int Disagreed { get; set; }
        public User User { get; set; }

    }


}
