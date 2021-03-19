using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class AppraiseFactory
    {

        private static void Create()
        {

        }
        private static Appraise  Generate(string name)
        {
            Appraise appraise = new Appraise();

            appraise.Voter = UserFactory.LiSi;
            appraise.Article = new Article() { }
        }



    }
}
