using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using sourcestack1.Repository;
using E = sourcestack1.Entity;
namespace sourcestack1.Pages.Problem
{
    public class IndexModel : PageModel
    {
        private ProblemRepository problemRepository;
        private const string pageIndex = "PageIndex";
        public int ProblemPageCount { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public IList<E.Problem> Problems { get; set; }
        public IndexModel()
        {
            problemRepository = new ProblemRepository();
        }
        public void OnGet()
        {
            PageIndex = Request.Query.TryGetValue(pageIndex, out StringValues result) ? Convert.ToInt32(result) : 1;

            //Problems = problemRepository.GetPages(PageIndex, PageSize);

            //ProblemPageCount = problemRepository.ArticlesCount % PageSize != 0 ?
            //articleRepository.ArticlesCount / PageSize + 1 : articleRepository.ArticlesCount / PageSize;
            //ArticlelPageCounts = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(articleRepository.ArticlesCount) / Convert.ToDouble(PageSize)));
        }
        public void Post()
        {


        }
    }
}
