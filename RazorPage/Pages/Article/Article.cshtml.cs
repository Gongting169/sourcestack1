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
        public int  ArticlelPageCounts { get; set; }
        public int PageIndex { get; set; } 
        public int PageSize { get; set; } = 2;
        public string Path { get; set; } = "/Article/Article?PageIndex";
        public IList<E.Article> Articles { get; set; }
        public ArticleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public void OnGet()
        {
            if (Request.Query.ContainsKey("PageIndex"))
            {
                PageIndex = Convert.ToInt32(Request.Query["PageIndex"][0]);
            }//else nothing
            //Request.RouteValues.TryGetValue("PageIndex", out object PageIndex?) ? PageIndex = Convert.ToInt32(Request.Query["PageIndex"][0]) : PageIndex = 1;
            Articles = new ArticleRepository().Get((int)PageIndex, PageSize);    
            ArticlelPageCounts = articleRepository.ArticlesCount % PageSize != 0 ? 
            ArticlelPageCounts = articleRepository.ArticlesCount / PageSize + 1 : ArticlelPageCounts = articleRepository.ArticlesCount / PageSize;
            ArticlelPageCounts = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(articleRepository.ArticlesCount) / Convert.ToDouble(PageSize)));
        }
        public void Post()
        {

        }
    }
}
