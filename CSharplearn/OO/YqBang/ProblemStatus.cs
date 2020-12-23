using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.OO.YqBang
{
    public class ProblemStatus:Entity
    {
        public string Name { get; set; }
        public Problem Problem { get; set; }
        public int ProblemId { get; set; }
    }
}
