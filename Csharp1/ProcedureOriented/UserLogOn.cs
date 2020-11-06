using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureOriented
{
    class UserLogOn
    {
        //http://17bang.ren/Article/299
        //作业：方法基础、声明、调用、返回值
        //1、将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。
        //http://17bang.ren/Article/263
        //面向过程： if。。。else
        //观察一起帮登录页面，用if...else...完成以下功能。 
        //用户依次由控制台输入：验证码、用户名和密码： 
        //如果验证码输入错误，直接输出：“* 验证码错误”； 
        //如果用户名不存在，直接输出：“* 用户名不存在”； 
        //如果用户名或密码错误，输出：“* 用户名或密码错误” 
        //以上全部正确无误，输出：“恭喜！登录成功！”
        //static bool LogOnyqbang(string Username, string Password, string ValidateCode, out string reason)
        //{
        //    string InvalideCode = "ut91";
        //    string username = "yezi";
        //    string password = "1234";
        //    Console.WriteLine("请输入验证码:");
        //    if (InvalideCode == Console.ReadLine () )
        //    {
        //        Console.WriteLine("请输入用户名:");
        //        if (username  == Console.ReadLine ())
        //        {
        //            Console.WriteLine($"请输入密码:");
        //            if (password ==  Console.ReadLine ())
        //            {
        //                reason = " “恭喜！登录成功！” ";
        //                return true;
        //            }
        //            else
        //            {
        //                reason = " “* 用户名或密码错误”   ";
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            reason = " “*用户名不存在”  ";
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        reason = " “* 验证码错误” ";
        //        return false;
        //    }
        //}
        //http://17bang.ren/Article/303
        //作业：C#面向过程：方法进阶：值/引用传递。
        //2、将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
        //（1）、true/false，表示登陆是否成功
        //（2）、string，表示登陆失败的原因
        //static bool LogOn(string username, string password, string verificationcode, out string reason)
        //{
        //    verificationcode = "ut91";
        //    username = "yezi";
        //    password = "1234";
        //    if (verificationcode == Console.ReadLine ())
        //    {
        //        if (username == Console.ReadLine ())
        //        {
        //            if (password == Console.ReadLine ())
        //            {
        //                reason = " 恭喜！登陆成功";
        //                return true;
        //            }
        //            else
        //            {
        //                reason = " *密码错误* ";
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            reason = " *用户名不存在* ";
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        reason = " *验证码错误* ";
        //        return false;
        //    } 
        //



    }
}
