using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharplearn;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharplearn = sourcestack1.Pages.Article;
namespace CSharplearn
{
    public class SingleModel : PageModel
    {
        public SingleModel()
        {
            artcleRepository = new ArtcleRepository();
        }
        public Article Article { get; set; }

        private ArtcleRepository artcleRepository;
     
        public void OnGet()
        {
            //Article = new ArticleRepository();
        }
    }

    internal class ArtcleRepository
    {
    }
}
