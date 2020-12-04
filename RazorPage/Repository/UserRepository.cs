using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class UserRepository
    {
        private static IList<User> user;
        static UserRepository()
        {
            user = new List<User>()
            {
                new User() { Id = 1, Name = "大飞哥",Password ="1234"} ,
                new User() { Id = 2, Name = "马保国",Password ="2356"},
                new User() { Id = 3, Name = "马云" ,  Password="1596"},
                new User() { Id = 4, Name = "赵日天",Password="1478"}
            };
        }

        public User Find(int id )
        {
            return user.Where(u => u.Id == id).FirstOrDefault();
        }

    }
}
