using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //https://zhuanlan.zhihu.com/p/92362781
    //    观察“一起帮”的：
    //1、注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
    //2、求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    //3、帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    //4、为这些类的字段和方法设置合适的访问修饰符。

    public class User
    {
        string name;
        string password;
          User InvitedBy;
        static  bool Register(User user, string InviteCode,string verrificationCode,string verifypassword,out string output)
        {
           
            output = "";
            return true;
        }
        static bool LogIn(string username, string password, string verificationcode, out string reason)
        {
            if (verificationcode.Length == 4)
            {
                if (verificationcode == verificationcode)
                {
                    if (username == username)
                    {
                        if (username != "")
                        {
                            if (password.Length < 4)
                            {
                                if (password.Length > 20)
                                {
                                    if (password != "")
                                    {
                                        reason = "";
                                        return true;
                                    }
                                    else
                                    {
                                        reason = " 密码不能为空 ";
                                        return false;
                                    }
                                }
                                else
                                {
                                    reason = " 密码的长度不能小于4，大于20 ";
                                    return false;
                                }
                            }
                            else
                            {
                                reason = "密码的长度不能小于4，大于20";
                                return false;
                            }
                        }
                        else
                        {
                            reason = " 用户名不能为空  ";
                            return false;
                        }
                    }
                    else
                    {
                        reason = " 用户名不存在 ";
                        return false;
                    }
                }
                else
                {
                    reason = " 验证码错误，请重新输入 ";
                    return false;
                }
            }
            else
            {
                reason = " 验证码的长度只能等于4 ";
                return false;
            }
        }

     
    }
 
}
