﻿using System;

namespace Csharp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //http://17bang.ren/Article/292
            //作业：运算符和表达式
            //输出两个整数 / 小数的和 / 差 / 积 / 商
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

            //电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
            //float a = 23F, b = 7F;
            //int i = 12, j = 8;
            //double c = 6;
            //Console.WriteLine(((a + b) * i - j) / c);

            //想一想以下语句输出的结果：
            //  int i = 15;
            //Console.WriteLine(i++);  ////15 

            //int i = 15;
            //i -= 5;
            //Console.WriteLine(i); ////10
            //Console.WriteLine(i >= 10); ////true

            //int i = 15; 
            //Console.WriteLine("i值的最终结果为：" + i); ////i值的最终结果为: 15

            //int i = 15;
            //int j = 20;
            //Console.WriteLine($"{i}+{j}={i+j}"); ////15+20=35

            //想一想如下代码的结果是什么，并说明原因： 
            //int a = 10;
            //Console.WriteLine(a>9&&(!(a <11)||a>10));////a <11 为真，取反为假，或为假，&为假

            //当a为何值时，结果为true？ //当 a = 10的时候，结果为真
            //bool result =(a+3>12)&& (a < 3.14*4) && (a != 11);
            //Console.WriteLine(result);

            //http://17bang.ren/Article/263
            //作业：面向过程：分支、if...else
            //观察一起帮登录页面，用if...else ...完成以下功能。 
            //用户依次由控制台输入：验证码、用户名和密码： 
            //如果验证码输入错误，直接输出：“*验证码错误”； 
            //如果用户名不存在，直接输出：“*用户名不存在”； 
            //如果用户名或密码错误，输出：“*用户名或密码错误” 
            //以上全部正确无误，输出：“恭喜！登录成功！”          
            //string InvalideCode = "ut91", UserName = "yezi", password = "1234", output;
            //Console.WriteLine("请输入验证码(ut91) :");
            //if (InvalideCode == Console.ReadLine())
            //{
            //    Console.WriteLine("请输入用户名(yezi):");
            //    if (UserName == Console.ReadLine())
            //    {
            //        Console.WriteLine($"请输入用户名(yezi)和密码(1234):");
            //        if (UserName == Console.ReadLine() && password == Console.ReadLine())
            //        {
            //            output = "  “恭喜！登录成功！”  ";
            //        }
            //        else
            //        {
            //            output = " “* 用户名或密码错误”   ";
            //        }
            //    }
            //    else
            //    {
            //        output = " “*用户名不存在”  ";
            //    }
            //}
            //else
            //{
            //    output = " “* 验证码错误” ";
            //}
            //Console.WriteLine(output);

            //http://17bang.ren/Article/294
            //作业：面向过程：数组
            //将源栈同学姓名 / 昵称分别： 
            //按进栈时间装入一维数组， 
            //按座位装入二维数组， 
            //并输出共有多少名同学。
            //string[] name = new string[] { "刘伟——小刘", "李智博——小李", "周丁浩——小周", "龚廷义——小龚", "廖光银——小廖", "邹丽——小邹" };
            //string[,] seatname = new string[4, 3];
            //seatname[1, 0] = "刘伟——小伟";
            //seatname[3, 0] = "龚廷义——小龚";
            //seatname[0, 1] = "李智博——小李";
            //seatname[1, 1] = "周丁浩——小周";
            //seatname[2, 1] = "廖光银——小廖";
            //seatname[0, 2] = "邹丽——小邹";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(seatname.Rank);

            //作业：C#面向过程：循环
            //1、分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //for (int i = 1; i < 6; i++) ////for 循环输出1,2,3,4,5
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i <10; i+=2) //// for 循环输出1,3,5,7,9
            //{
            //    Console.WriteLine(i);
            //}
            //int j = 1;
            //while (j < 6)  //// while循环输出1,3，5,7,9
            //{
            //    Console.WriteLine(2*j-1);
            //    j++;
            //}
            //2、用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //string[] name = new string[] { "刘伟——小刘", "李智博——小李", "周丁浩——小周", "龚廷义——小龚", "廖光银——小廖", "邹丽——小邹" };
            //string[,] seatname = new string[4, 3];
            //for (int i = 0; i < name.Length; i++)//一维数组里取值
            //{
            //    Console.WriteLine(name[i]);
            ////}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        string s = seatname[i, j];
            //        Console.WriteLine(s);


    //3、让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
    //int sum = 0;
    //for (int i = 1; i < 100; i+=2)
    //{
    //    sum += i;
    //}
    //Console.WriteLine(sum );
    //4、将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
    //double[] score = { 76.52, 68.76, 99.6, 85.9, 65.8, 48.5 };
    //double max = score[0];
    //for (int i = 0; i < score.Length; i++) // 用循环找最高分
    //{
    //    if (score[i] > max)
    //    {
    //        max = score[i];
    //    }// else continue
    //}
    //Console.WriteLine(max);
    //double min = score[0];
    //for (int i = 1; i < score.Length; i++) // 循环找最低分
    //{
    //    if (score[i] < min)
    //    {
    //        min = score[i];
    //    }// else continue
    //}
    //Console.WriteLine(min);
    //5、找到100以内的所有质数（只能被1和它自己整除的数
    //for (int i = 2; i <= 100; i++)
    //{
    //    for (int j = 2; j < i; j++)
    //    {
    //        if (i % j == 0 )
    //        {
    //            break;
    //        }
    //        else if ( i-1 == j)
    //        {
    //            Console.WriteLine(i);
    //        }//else nothing
    //    }
    //}
    //6、生成一个元素（值随机）从小到大排列的数组
    int[] sort = { 132, 35, 26, 3, 18, 22, 16, 45, 53, 62, 7 };
       int middle;
            for (int i = 0; i < sort.Length -2; i++)  // 第二轮查找
            {
                for (int j = 0; j < sort.Length - 1; j++) // 第一轮查找
                {
                    if (sort[j] < sort[j + 1])
                    {
                        middle = sort[j + 1];
                        continue;
                    }
                    else
                    {
                       int  temp = sort[j];
                        sort[j] = sort[j + 1];
                        sort[j + 1] = temp;
                    }
                }
            }
            
          







    
            Console.ReadLine();
        }
    }
}

