using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class CommentRepository
    {
        private static IList<Comment> comments;
        static CommentRepository()
        {
            comments = new List<Comment>()
            {
                new Comment(){ Body ="马保国",Id=1 },
                new Comment(){ Body ="真不错",Id=2 },
                new Comment(){ Body ="我会闪电五连鞭",Id=3 },
                new Comment(){ Body ="我大意了" ,Id= 5},
                new Comment(){ Body ="没有闪" ,Id=6},
                new Comment(){ Body ="年轻人不讲武德",Id= 7 },
                new Comment(){ Body ="山里的环境真不错",Id=8 },
                new Comment(){ Body ="特朗普" ,Id=9},
                new Comment(){ Body ="回首掏" ,Id=10}
            };
        }
        public Comment Find(int id)
        {
            return comments.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
