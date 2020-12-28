using CSharplearn.OO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharplearn.OO.Entity_FrameWork
{
    public class EFWork
    {
        private SqlDbContext context;
        public EFWork()
        {
            context = new SqlDbContext();
        }
        public object GetBy(IList<ProblemStatus> exclude, bool hasSummary, bool descByPublishTime)
        {
            IQueryable<Problem> problems = context.Problems;
            if (exclude != null)
            {
                problems = problems.GetExclude(exclude);
            }//else nothing
            if (hasSummary)
            {
                problems = problems.GetHasReward(hasSummary);
            }
            //else nothing
            problems.GetOrderByPublishTime(descByPublishTime);
            return problems.ToList();
        }
    }
    public static class Extension
    {
        public static IQueryable<Problem> GetOrderByPublishTime(this IQueryable<Problem> problems, bool descByPublishTime)
        {
            if (descByPublishTime)
            {
                return problems.OrderBy(p => p.PublishTime);
            }
            else
            {
                return problems.OrderByDescending(p => p.PublishTime);
            }
        }
        public static IQueryable<Problem> GetHasReward(this IQueryable<Problem> problems, bool HasSummary)
        {
            if (HasSummary)
            {
                return problems.Where(p => p.Status == ProblemStatus.HaveReward || p.Status == ProblemStatus.Undo);
            }
            else
            {
                return problems.Where(p => p.Status != ProblemStatus.Undo || p.Status != ProblemStatus.HaveReward);
            }
        }
        public static IQueryable<Problem> GetExclude(this IQueryable<Problem> problems, IList<ProblemStatus> exclude)
        {
            return problems.Where(p => !exclude.Contains(p.Status));
        }
    }
}

