using GLB.Global;
using SRV.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace MVC.Helpers
{
    public class Helper
    {
        private static IUserService userService;
        public Helper()
        {
            userService = new SRV.MockService.MUserService();
            userService = new SRV.ProdService.UserService();
        }
        public static void Delete(string name)
        {

        }
        public static int? GetCurrentUserId()//是从cookie里面取值，取出userID来
        {
            ///1.能够顺利的拿到
            ///2、没有cookie 取不到
            ///3、有cookie，但验证通不过
            NameValueCollection userInfo = HttpContext.Current.Request.Cookies[Keys.User].Values;
            string pwdInCookie = userInfo[Keys.Password];
            bool hasUserId = int.TryParse(userInfo[Keys.Id], out int currentUserId);
            if (userInfo == null)
            {
                return null;
                //throw new ArgumentNullException($" 从cookie里取不到{userInfo}的值");
            }
            if (string.IsNullOrWhiteSpace(userInfo[Keys.Id]))
            {
                throw new ArgumentNullException($" 从cookie里面找不到ID的值");
            }
            if (string.IsNullOrWhiteSpace(pwdInCookie))
            {
                throw new ArgumentNullException($" 从cookie里面找不到ID所对应的Password的值");
            }
            if (userService.GetPwdById(currentUserId) != pwdInCookie.MD5EnCrypt())
            {
                throw new ArgumentException($" 输入的密码无法匹配");
            }
            if (!hasUserId)
            {
                // 应该要删除cookie
                //throw new ArgumentException("无法从cookie里取到值");
            }
            return currentUserId;
        }


    }
}