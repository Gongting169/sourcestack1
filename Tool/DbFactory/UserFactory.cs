
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

        internal static User ZhangSan, LiSi, XiaoWei, WangWu;
        internal static void Creat()
        {
            ZhangSan = Register("张三");
            LiSi = Register("李四");
            XiaoWei = Register("小伟");
            WangWu = Register("王五");
        }

        private static User Register(string name)
        {
            const string pwd = "1234";
            User user = new User();
            user.Name = name;
            user.Password = pwd;
            user.InvitedById = 1;
            user.Register();
            new UserRepository(Helper.GetDbContext()).Save(user);
            return user;
        }
































    }
}
