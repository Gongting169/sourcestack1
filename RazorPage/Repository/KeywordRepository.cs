using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class KeywordRepository
    {
        private static IList<Keyword> Keywords;
        static KeywordRepository()
        {
            Keywords = new List<Keyword>
            {
                new Keyword(){ Id = 1,Name="C#"},
                new Keyword(){Id=2,Name ="vs"},
                new Keyword(){Id= 3,Name ="html"},
                new Keyword(){Id= 4,Name ="入门"},
                new Keyword(){Id= 5,Name ="ES6"},
                new Keyword(){Id= 6,Name ="回调地狱"},
                new Keyword(){Id= 7,Name ="promise"},
                new Keyword(){Id= 8,Name ="JQuery"},
                new Keyword(){Id= 9,Name ="AJax"},
                new Keyword(){Id= 10,Name ="表单"},
                new Keyword(){Id= 11,Name ="后台"},
                new Keyword(){Id= 12,Name ="插件"},
                new Keyword(){Id= 13,Name ="集合"},
                new Keyword(){Id= 14,Name ="介绍"},
                new Keyword(){Id= 15,Name ="历史"},
                new Keyword(){Id= 16,Name ="JavaScript"},
                new Keyword(){Id= 17,Name ="冒泡"},
                new Keyword(){Id= 18,Name ="事件"},
                new Keyword(){Id= 19,Name ="999天"},
                new Keyword(){Id= 20,Name ="晚7点"},
                new Keyword(){Id= 21,Name ="NoSql"},
            };
        }
        public Keyword Find(int id)
        {
            return Keywords.Where(k => k.Id == id).SingleOrDefault();
        }
    }
}
