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
        public int ArticleTotalPages { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public ArticleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public IList<E.Article> articles { get; set; }
        public void OnGet()
        {
            PageIndex = 1;
            if (Request.Query.ContainsKey("pageIndex"))
            {
                PageIndex = Convert.ToInt32(Request.Query["pageIndex"][0]);
            }
            articles = new ArticleRepository().Get(PageIndex, 2);
            ArticleTotalPages = articleRepository.ArticlesCount;
        }




    }
}
