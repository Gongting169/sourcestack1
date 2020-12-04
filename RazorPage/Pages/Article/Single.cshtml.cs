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
        private ArticleRepository articleRepository;
        public SingleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public void OnGet()
        {
        }
    }

}
