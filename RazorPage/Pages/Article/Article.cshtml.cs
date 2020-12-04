using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sourcestack1.Entity;
using sourcestack1.Repository;
using E = sourcestack1.Entity;
namespace sourcestack1.Pages.Article
{
    public class ArticleModel : PageModel
    {
        private ArticleRepository articleRepository;
        public double ArticlelPageCounts { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string Path { get; set; } = "/Article/Article?PageIndex";
        public int CurrentPageIndex { get; set; }
        public IList<E.Article> articles { get; set; }
        public ArticleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public void OnGet()
        {
            if (Request.Query.ContainsKey("PageIndex"))
            {
                PageIndex = Convert.ToInt32(Request.Query["PageIndex"][0]);
                CurrentPageIndex = Convert.ToInt32(Request.Query["PageIndex"][0]);
            }
            articles = new ArticleRepository().Get(PageIndex, PageSize);
            ArticlelPageCounts = Math.Ceiling(((double)articleRepository.ArticlesCount) / PageSize);
        }
    }
}
