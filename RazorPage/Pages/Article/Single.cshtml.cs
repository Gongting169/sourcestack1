using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E = sourcestack1.Entity;
using sourcestack1.Repository;
namespace sourcestack1.Pages.Article
{
    public class SingleModel : PageModel
    {
        public SingleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public E.Article Article { get; set; }

        private ArticleRepository articleRepository;

        public void OnGet()
        {
            //int id = Convert.ToInt32(Request.Query["id"]);
            //Article = articleRepository.Find(8);
        }
    }

}
