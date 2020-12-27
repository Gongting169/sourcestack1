using CSharplearn;
using CSharplearn.OO.Entity_FrameWork;
using CSharplearn.OO.YqBang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class ProblemRepository
    {
        //public object GetBy(IList<ProblemStatus> exclude, bool hasSummary, bool descByPublishTime)
        //{
        //    //SqlDbContext context = new SqlDbContext();
        //    //var problem = exclude.AsQueryable<ProblemStatus>().Where(p => p.Id > 0);
        //    //foreach (var item in exclude)
        //    //{
        //    //    if (problem.Any(p=>p.Id == item.Id))
        //    //    {
        //    //        context.ProblemStatuses.Where(P => P.Id != item.Id);
        //    //    }
        //    //    else
        //    //    {
        //    //        throw new Exception();
        //    //    }          
        //    //}
        //    //Problem result = descByPublishTime ? context.Problems.OrderBy(p => p.PublishTime).SingleOrDefault() :
        //    //    context.Problems.OrderByDescending(p => p.PublishTime).SingleOrDefault();

        //    //ProblemStatus status = hasSummary ? context.ProblemStatuses.Where(p => p.Name == "已酬谢" || p.Name == "已撤销").SingleOrDefault() :
        //    //    context.ProblemStatuses.Where(p => p.Name != "已酬谢" || p.Name != "已撤销").SingleOrDefault();// or throw new Exception(); //抛异常  
        //    //return 3;
        //}



    }
}
