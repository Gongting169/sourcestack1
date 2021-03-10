using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFactory
{
    public class UserFactory
    {
        private static SqlDbContext _context;
        static UserFactory()
        {
            _context = new SqlDbContext();
        }

        public const string pwd = "1234";
        internal static void Creat()
        {
            User xiaowei = Register("小伟");
            User xiaoliu = Register("小刘");
            User xiaozhu = Register("小朱");
            User xiaotian = Register("小田");

        }

        private static User Register(string name)
        {
            User xiaowei = new User()
            {
                Name = name,
                Password = pwd,
                Id = 1,

            };
            xiaowei.Register();
            _context.User.Add(xiaowei);
            _context.SaveChanges();
            //UserRepository userRepository = new UserRepository(Helper.GetDbContext1());
            //userRepository.Save(xiaowei);
            return xiaowei;
  


        }
































    }
}
