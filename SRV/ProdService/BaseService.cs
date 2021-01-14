using BLL.Entities;
using BLL.Repositories;
using GLB.Global;
using SRV.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SRV.ProdService
{
    public class BaseService
    {
        private UserRepository userRepository;
        public BaseService()
        {
            userRepository = new UserRepository(Context);
        }
        protected SqlDbContext Context
        {
            get
            {
                if (HttpContext.Current.Items[Keys.DbContext] == null)
                {
                    SqlDbContext context = new SqlDbContext();
                    context.Database.BeginTransaction();
                    HttpContext.Current.Items[Keys.DbContext] = new SqlDbContext();
                }//else nothing
                return (SqlDbContext)HttpContext.Current.Items[Keys.DbContext];
            }
        }

        public static void EndTransaction()
        {
            object objContext = HttpContext.Current.Items[Keys.DbContext];
            SqlDbContext cx = objContext as SqlDbContext;
            using (DbContextTransaction transaction = cx.Database.CurrentTransaction)
            {
                try
                {
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public User GetCurrentUser()//是从cookie里面取值，取出user来
        {
            NameValueCollection userInfo = HttpContext.Current.Request.Cookies[Keys.User].Values;
            string pwdInCookie = userInfo[Keys.Password];
            bool hasUserId = int.TryParse(userInfo[Keys.Id], out int currentUserId);
            User current = userRepository.Find(currentUserId);
            if (userInfo == null)
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(userInfo[Keys.Id]))
            {
                throw new ArgumentNullException($" 从cookie里面找不到ID的值");
            }
            if (string.IsNullOrWhiteSpace(pwdInCookie))
            {
                throw new ArgumentNullException($" 从cookie里面找不到ID所对应的Password的值");
            }
            if (current.Password != pwdInCookie)
            {
                throw new ArgumentException($" 输入的密码无法匹配");
            }
            if (!hasUserId)
            {
                // 应该要删除cookie
                //如果当前用户未登录
                //throw new ArgumentException("无法从cookie里取到值");
            }
            return current;
        }


    }
}
