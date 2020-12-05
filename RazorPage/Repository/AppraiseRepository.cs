using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class AppraiseRepository
    {
        private static IList<Appraise> appraises;
        static AppraiseRepository()
        {
            appraises = new List<Appraise>()
            {
                new Appraise (){ Direction =  AppraiseDirection.Down ,Id =1},
                new Appraise (){ Direction =  AppraiseDirection.Up   ,Id=2}
            };
        }
        public Appraise Find(int id)
        {
            return appraises.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
