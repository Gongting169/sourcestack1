using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharplearn.OO.YqBang
{
    class ArticleRepository : Repoistory
    {
        public static IList<Article> articles;
        //static ArticleRepository()
        //{
        //    articles = new List<Article> 
        //    { 
        //      new Article 
        //     { 
             
        //     }
        //      Author = new User
        //      {

        //      }
        //    };
        //}
        public ArticleRepository()
        {

        }

        public Article Find()
        {
            


          return  articles.Where(a => a.Id ==Id).SingleOrDefault();
           
        }

        public override void Delete()
        {

        }
        public override void Save()
        {

        }
    }
}
