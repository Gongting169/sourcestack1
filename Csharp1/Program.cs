using System;

namespace Csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业：运算符和表达式
            // int a = 3, b = 2;
            // Console.WriteLine(a +b);
            // Console.WriteLine(a - b);
            // Console.WriteLine(a * b);
            // Console.WriteLine(a / b);


            //double  n = 5.4, m = 3.6;
            // Console.WriteLine(n + m);
            // Console.WriteLine(n - m);
            // Console.WriteLine(n * m);
            // Console.WriteLine(n / m);

            //float a = 23F, b = 7F;
            //int i = 12, j = 8;
            //double c = 6;
            //Console.WriteLine(((a + b) * i - j) / c);

            //  int i = 15;
            //Console.WriteLine(i++);  15 

            //int i = 15;
            //i -= 5;
            //Console.WriteLine(i); 10
            //Console.WriteLine(i >= 10); true

            //int i = 15; 
            //Console.WriteLine("i值的最终结果为：" + i); i值的最终结果为: 15

            //int i = 15;
            //int j = 20;
            //Console.WriteLine($"{i}+{j}={i+j}"); 15+20=35

            //int a = 10;
            //Console.WriteLine(a>9&&(!(a <11)||a>10));//a <11 为真，取反为假，或为假，&为假

            //int a = 10;
            //bool result =(a+3>12)&& (a < 3.14*4) && (a != 11);
            //Console.WriteLine(result);


            //作业：面向过程：分支、if...else
            //观察一起帮登录页面，用if...else ...完成以下功能。 
            //用户依次由控制台输入：验证码、用户名和密码： 
            //如果验证码输入错误，直接输出：“*验证码错误”； 
            //如果用户名不存在，直接输出：“*用户名不存在”； 
            //如果用户名或密码错误，输出：“*用户名或密码错误” 
            //以上全部正确无误，输出：“恭喜！登录成功！”
            //Console.WriteLine($"请输入验证码 (ut91) :");
            //string InvalideCode = Console.ReadLine();
            //if (InvalideCode =="ut91")
            //{
            //    Console.WriteLine(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine($" “*验证码错误” ");
            //}
            //Console.WriteLine($"请输入用户名 (yezi):");
            //string UserName = Console.ReadLine();
            //if (UserName =="yezi")
            //{
            //    Console.WriteLine(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine(" “*用户名不存在” ");
            //}
            //int password = Convert.ToInt32(Console.ReadLine());
            //if (password != Convert.ToInt32(Console.ReadLine()) || UserName !="yezi")
            //{
            //    Console.WriteLine(" “* 用户名或密码错误”  ");
            //}
            //else
            //{
            //    Console.WriteLine(" “恭喜！登录成功！” ");
            //}
            Console.WriteLine($"请输入验证码 (ut91) :");
            Console.WriteLine($"请输入用户名 (yezi):");
            string  InvalideCode = Console.ReadLine(), UserName = Console.ReadLine(), password = Console.ReadLine();
            if (InvalideCode == "ut91"|| UserName == "yezi" || password != Console.ReadLine() )
            {
                Console.WriteLine(Console.ReadLine());
                Console.WriteLine(Console.ReadLine());
            } else
            {
                Console.WriteLine($" “*验证码错误” ");
                Console.WriteLine(" “*用户名不存在” ");
                Console.WriteLine(" “* 用户名或密码错误”  ");
                Console.WriteLine(" “恭喜！登录成功！” ");

            }

            Console.ReadLine();
        }
    }
}
