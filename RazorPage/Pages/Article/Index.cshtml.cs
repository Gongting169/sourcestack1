using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sourcestack1.Repository;
using E = sourcestack1.Entity;
namespace sourcestack1.Pages.Article
{
    public class ArticleModel : PageModel
    {
        private ArticleRepository articleRepository;
        public ArticleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public IList<E.Article> Articles { get; set; }
        public void OnGet()
        {
            Articles = articleRepository.Get();
        }
    }
}
