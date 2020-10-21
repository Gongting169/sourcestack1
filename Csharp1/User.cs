using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
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
                if (user.InvitedCode==InvitedCode)
                {
                    if (user.Name !=Name)
                    {

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

        public void LogIn()
        {

        }
    }
}
