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
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public ArticleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public IList<E.Article> Articles { get; set; }
        public void OnGet()
        {
            PageIndex = Convert.ToInt32(Request.Query["PageIndex"][PageSize]);
            Articles = articleRepository.Get(PageIndex, 5);
        }




    }
}
