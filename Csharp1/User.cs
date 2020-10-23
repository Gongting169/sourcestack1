using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //https://zhuanlan.zhihu.com/p/92362781
    //    观察“一起帮”的：
    //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    //为这些类的字段和方法设置合适的访问修饰符。

    public class User
    {
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (Name.Length > 0)
                {
                    if (Name.Length < 20)
                    {
                        Name = value;
                    }
                    else
                    {
                        Console.WriteLine("用户名不能大于20");
                    }
                }
                else
                {
                    Console.WriteLine("用户名不能为空");
                }
            }
        }
        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                if (Password.Length > 0)
                {
                    if (Password.Length > 4 && Password.Length < 20)
                    {
                        Password = value;
                    }
                    else
                    {
                        Console.WriteLine("密码的长度不能小于4,大于20");
                    }
                }
                else
                {
                    Console.WriteLine("密码不能为空");
                }
            }
        }
        public string InvitedBy
        {
            get
            {
                return InvitedBy;
            }
            set
            {
                if (InvitedBy.Length > 0)
                {
                    if (InvitedBy.Length < 20)
                    {
                        InvitedBy = value;
                    }
                    else
                    {
                        Console.WriteLine("邀请人的长度不能大于20");
                    }
                }
                else
                {
                    Console.WriteLine("邀请人不能为空");
                }
            }
        }
        public string InvitedCode
        {
            get
            {
                return InvitedCode;
            }
            set
            {
                if (InvitedCode.Length > 0)
                {
                    if (InvitedCode.Length == 4)
                    {
                        if (int.TryParse(InvitedCode, out int number))
                        {
                            Name = value;
                        }
                        else
                        {
                            Console.WriteLine("邀请码只能是4位数字");
                        }
                    }
                    else
                    {
                        Console.WriteLine("邀请码只能是4位数字");
                    }
                }
                else
                {
                    Console.WriteLine("邀请码只能是4位数字");
                }
            }
        }
        public bool Register(User user, out string cause)
        {
            if (user.InvitedBy == InvitedBy)
            {
                if (user.InvitedCode == InvitedCode)
                {
                    if (user.Name != Name)
                    {
                        cause = "";
                        return true;
                    }
                    else
                    {
                        cause = "用户名已存在";
                        return false;
                    }
                }
                else
                {
                    cause = "邀请码不存在";
                    return false;
                }
            }
            else
            {
                cause = "邀请人不存在";
                return false;
            }
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
