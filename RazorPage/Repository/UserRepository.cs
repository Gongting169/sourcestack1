using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class UserRepository
    {
        private const string id = "Id";
        private const string password = "PASSWORD";
        private const string name = "USERNAME";
        private const string invitedBy = "InvitedBy";
        private static IList<User> users;
        static UserRepository()
        {
            users = new List<User>()
            {
                new User() { Id = 1, Name = "大飞哥",Password ="1234"} ,
                new User() { Id = 2, Name = "管理员",Password ="1562"},
                new User() { Id = 3, Name = "马云" ,  Password="1596"},
                new User() { Id = 4, Name = "赵日天",Password="1478"}
            };
        }
        public User Find(int id)
        {
            return users.Where(u => u.Id == id).SingleOrDefault();
        }
        //将之前ASP.NET项目中以下Repository方法用ADO.NET实现： 
        //注册 / 登录
        //内容：
        //发布 / 修改
        //单页呈现
        //列表页呈现（包括：过滤 / 分页） 
        //批量标记Message为已读
        public void Save(User user)
        {
            DbHelper helper = new DbHelper();
            IDbCommand command = new SqlCommand();
            IDataParameter pName = new SqlParameter("@Name", user.Name);
            IDataParameter pPassword = new SqlParameter("@Password", user.Password);
            IDataParameter pInvitedBy = new SqlParameter("@InvitedBy", user.InvitedBy.Id);
            helper.Insert($"INSERT [USER](USERNAME,PASSWORD,InvitedBy) VALUES(@Name,@Password,@InvitedBy);", pName, pPassword, pInvitedBy);
            //helper.executeNonQuery(command);
        }
        public IList<User> Get(int pageindex, int pagesize)
        {
            return users.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
        }
        public void Delete()
        {

        }
        //public User GetByName(string name)
        //{
        //    User user = new User();
        //    DbHelper helper = new DbHelper();
        //    IDataParameter pName = new SqlParameter("@name", name);
        //    ////IDbCommand command = new SqlCommand();
        //    ////IDataReader reader = helper.executeReader(command);
        //    //helper.ExecuteReader($"Select {Password} from [USER] Where {Name} = @name;", pName);
        //    ////if (!reader.Read())
        //    ////{
        //    ////    return null;
        //    ////}
        //    ////if (reader[Password].ToString() == null)
        //    ////{
        //    ////    Console.WriteLine(" 用户名不存在");
        //    ////    return null;
        //    ////}
        //    ////if (reader[Password].ToString() != user.Password)
        //    ////{
        //    ////    Console.WriteLine(" 用户名或者密码错误");
        //    ////    return null;
        //    ////}
        //    ////return (User)reader[Id];
        //    //return user;
        //}
    }
}
