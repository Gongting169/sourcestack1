﻿using AutoMapper;
using BLL.Entities;
using BLL.Repositories;
using GLB.Global;
using SRV.ServiceInterface;
using SRV.ViewModel;
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
        protected readonly static MapperConfiguration config;
        public BaseService()
        {
            userRepository = new UserRepository(Context);          
        }
        static BaseService()
        {
            config = new MapperConfiguration
                (cfg =>
                {
                    cfg.CreateMap<Article, ArticleNewModel>().ReverseMap();
                    cfg.CreateMap<User, UserModel>().ReverseMap();
                    cfg.CreateMap<User, RegisterModel>().ReverseMap();
                    cfg.CreateMap<User, LogOnModel>().ReverseMap();
                }
            );
        }
        protected IMapper mapper
        {
            get { return config.CreateMapper(); }
        }

        protected SqlDbContext Context
        {
            get
            {
                if (HttpContext.Current.Items[Keys.DbContext] == null)
                {
                    SqlDbContext context = new SqlDbContext();
                    context.Database.BeginTransaction();
                    HttpContext.Current.Items[Keys.DbContext] = context;
                }//else nothing
                return (SqlDbContext)HttpContext.Current.Items[Keys.DbContext];
            }
        }
        private static SqlDbContext getContextFromHttp()
        {
            object objContext = HttpContext.Current.Items[Keys.DbContext];
            return objContext as SqlDbContext;
        }
        public static void Commit()
        {
            SqlDbContext cx = getContextFromHttp();
            if (cx != null)
            {
                using (cx)
                {
                    using (DbContextTransaction transaction = cx.Database.CurrentTransaction)
                    {
                        transaction.Commit();
                    }
                }
            }
        }
        public static void RollBack()
        {
            SqlDbContext cx = getContextFromHttp();
            if (cx != null)
            {
                using (cx)
                {
                    using (DbContextTransaction transaction = cx.Database.CurrentTransaction)
                    {
                        transaction.Rollback();
                    }
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
            if (string.IsNullOrWhiteSpace(pwdInCookie))
            {
                throw new ArgumentNullException($" 从cookie里面找不到ID所对应的Password的值");
            }
            if (current.Password != pwdInCookie.MD5EnCrypt())
            {
                throw new ArgumentException($" 参数异常无法匹配");
            }
            if (!hasUserId)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[Keys.User];
                cookie.Expires = DateTime.Now.AddDays(-1);
                cookie.Values.Clear();
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            return current;
        }
    }
}
