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
        public object GetBy(IList<ProblemStatus> exclude, bool hasSummary, bool descByPublishTime)
        {
            SqlDbContext context = new SqlDbContext();
            if (descByPublishTime)
            {

            }
            else
            {

            }
            if (hasSummary)
            {
                
            }
            else//显示没有总结的求助
            {

            }
            //else
            //{
            //throw new Exception(); //抛异常     
            //}
            return 3;
        }



    }
}
