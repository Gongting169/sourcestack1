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
        public Article Article { get; set; }
        public string Title { get; set; }

        public string Body { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        private ArtcleRepository artcleRepository;
        public SingleModel()
        {
            artcleRepository = new ArtcleRepository();
        }
        public void OnGet()
        {
            //Article = new ArticleRepository();
        }
    }

    internal class ArtcleRepository
    {
    }
}
