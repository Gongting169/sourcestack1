using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.OO.YqBang
{
    public class Category:Entity
    {
        public string Title { get; set; }
        public IList<Article> Articles { get; set; }
        public string Body { get; set; }




    }
}
