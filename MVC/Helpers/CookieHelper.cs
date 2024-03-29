﻿using GLB.Global;
using SRV.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace MVC.Helpers
{
    public class CookieHelper
    {
        private static IUserService service;//使用cookiehelper的原因是：controller调用baseservice的方法，按照视频的写法 需要添加对entity的引用
        //当返回的是一个id时 ，会造成Stack Overflow异常，而且代码有部分重复查询浪费性能
        public CookieHelper()
        {
            service = new SRV.ProdService.UserService();
        }
        public static void Delete()
        {

        }
        public static int? GetCurrentUserId()
        {
            NameValueCollection userInfo = HttpContext.Current.Request.Cookies[Keys.User].Values;
            string pwdInCookie = userInfo[Keys.Password];
            bool hasUserId = int.TryParse(userInfo[Keys.Id], out int currentUserId);
            string pwd = service.GetPwdById(currentUserId);
            if (userInfo == null)
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(pwdInCookie))
            {
                throw new ArgumentNullException($" 从cookie里面找不到ID所对应的Password的值");
            }
            if (pwd != pwdInCookie.MD5EnCrypt())
            {
                throw new ArgumentException($" 参数异常无法匹配");
            }
            if (!hasUserId)
            {
                HttpCookie damagedCookie = HttpContext.Current.Request.Cookies[Keys.User];
                damagedCookie.Expires = DateTime.Now.AddDays(-1);
                damagedCookie.Values.Clear();
                HttpContext.Current.Response.Cookies.Add(damagedCookie);
            }
            //HttpCookie cookie = HttpContext.Current.Request.Cookies[Keys.User];
            //cookie.Values.Add(Keys.Id, currentUserId.ToString());
            //cookie.Values.Add(Keys.Password, pwd);
            //HttpContext.Current.Response.Cookies.Add(cookie);
            return currentUserId;
        }

    }
}