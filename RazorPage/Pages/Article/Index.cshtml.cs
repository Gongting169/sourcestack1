using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E = CSharplearn.OO.YqBang;
namespace sourcestack1.Pages.Article
{
    public class ArticleModel : PageModel
    {
        public IList<E.Article> Articles { get; set; }
        public void OnGet()
        {

        }
    }
}
