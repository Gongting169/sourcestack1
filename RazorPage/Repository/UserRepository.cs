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
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=18BANG;Integrated Security=True;";
            //using (IDbConnection connection1 = new SqlConnection(connectionString))
            //{
            //    connection1.Open();
            //    IDbCommand command = new SqlCommand();
            //    command.Connection = connection1;
            //    command.CommandText = " SELECT ID from [USER] WHERE PASSWORD =@Password AND USERNAME =@Name";
            //    IDataParameter pPassword = new SqlParameter("@password",user.Password);
            //    IDataParameter pName = new SqlParameter("@Name",user.Name);
            //    command.Parameters.Add(pName);
            //    command.Parameters.Add(pPassword);

            //    IDataReader reader = command.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        command.CommandText = $"  INSERT [USER] VALUES({user.Name},{user.Password},{user.InvitedBy.Id})";
            //        command.ExecuteNonQuery();
            //    }
            //}
            //using (IDbConnection connection2 = new SqlConnection(connectionString))
            //{
            //    connection2.Open();
            //    IDbCommand command = new SqlCommand();
            //    command.Connection = connection2;
            //    command.CommandText = "   ";
            //}
            //users.Add(user);
        }
        public IList<User> Get(int pageindex, int pagesize)
        {
            return users.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
        }
        public void Delete()
        {

        }
        public User GetByName(string name)
        {
            User user = new User();
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=18BANG;Integrated Security=True;";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                IDataParameter pName = new SqlParameter("@name", user.Name);
                command.Parameters.Add(pName);
                command.CommandText = $"Select PASSWORD from [USER] Where [USERNAME] = @name;";
                string dbPassWord = command.ExecuteScalar().ToString();
                if (dbPassWord == null)
                {
                    Console.WriteLine("用户名不存在");
                    return user;
                }
                if (dbPassWord != user.Password)
                {
                    Console.WriteLine("用户名或者密码错误");
                    return user;
                }
            }
            return users.Where(u =>u.Name == name).SingleOrDefault();
        }
    }
}
