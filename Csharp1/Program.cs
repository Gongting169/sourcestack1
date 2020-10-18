using System;
using System.Security.Cryptography;

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
            //int[] ascend  = new int[10];
            //Random value  = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    ascend [i] = value.Next(0, 100);
            //}
            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = i + 1; j < 10; j++)
            //    {
            //        if (ascend [j] < ascend [i])
            //        {
            //            int temp = ascend[i];
            //           ascend[i] = ascend [j];
            //            ascend [j] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < ascend.Length ; i++)
            //{
            //    Console.WriteLine(ascend[i]);
            //}
            //7、设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()// 定义一个多维数组， 用for循环把数组的下标值相加起来是元素值
            //int[,] add = new int[3, 4];
            //int sum;  //用sum来代表下标之和
            //for (int i = 0; i < add.GetLength(0); i++)
            //{
            //    for (int j = 0; j < add.GetLength(1); j++)
            //    {
            //        //sum = add[i, j];
            //        sum = i + j;
            //        Console.WriteLine(sum);
            //    }
            //}
            //8、循环：布置的作业二分查找：
            //题目：如何在一个有序的数组中查找某个元素。
            int[] seek = { 20, 25, 32, 46, 50, 62, 76, 81, 96 };
            int target = 81,middle;
            int right = seek.Length - 1;
            int left = 0;
            bool result = false;
            while (left != right )
            {
                 middle = (left + right) / 2;
                if (target > seek[middle])
                {
                    left = middle; //注意数组是从小到大排序还是从大到小排序，从小到大的话，先是左然后是右。
                }
                else if (target < seek[middle])
                {
                    right = middle;
                } // else target == middle
                {
                    result = true;
                    break;
                }
            }


            //http://17bang.ren/Article/299
            //调用函数的作业：
            //作业：方法基础： 声明/调用/返回值
            //第2小题的调用：
            //double[] score = { 76.52, 68.76, 99.6, 85.9, 65.8, 48.5 };
            //Console.WriteLine(Math.Round(GetAverage(score), 2));

            //http://17bang.ren/Article/303
            //作业：C#面向过程：方法进阶：值/引用传递。
            //第1小题的调用：
            //int bednumber1 = 202, bednumber2 = 203;
            //Swap(ref bednumber1, ref bednumber2);
            ////第2小题的调用：
            //LogOn(out string username, out string Password);

            Console.ReadLine();
        }
        //http://17bang.ren/Article/299
        //作业：方法基础、声明、调用、返回值
        //1、将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。
        //2、计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        static double GetAverage(double[] score)
        {
            double sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum = sum + score[i];
            }
            float average = Convert.ToSingle(sum / score.Length);
            return average;
        }
        //3、完成“猜数字”游戏，方法名GuessMe()：
        //随机生成一个大于0小于1000的整数
        //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了” 
        //没猜中可以继续猜，但最多不能超过10次         //具体的思路：应该要把用户的输入值给考虑到位，如果出现不符合要求的输入值怎么办？
        //如果5次之内猜中，输出：你真牛逼！            
        //如果8次之内猜中，输出：不错嘛！ 
        //10次还没猜中，输出：(～￣(OO)￣)ブ 
        //static void GuessMe()
        //{
        //    Random value = new Random();
        //    int result = value.Next(0, 1000);
        //    Console.WriteLine("请输入一个不超过1000的自然数：");
        //     int guessnum = int.TryParse(Console.ReadLine()) ;
        //    for (int i = 10; i < 10; i++)
        //    {
        //        if (guessnum > result)
        //        {
        //            Console.WriteLine($"太大了哟！ (还剩 {1}次)");
        //        }
        //        else
        //        {
        //            Console.WriteLine("太小了哟！" + "还剩8次");
        //        }
        //        {

        //        }
        //    }
        //}
        //http://17bang.ren/Article/303
        //作业：C#面向过程：方法进阶：值/引用传递。
        //作业题目：1、利用ref调用Swap()方法交换两个同学的床位号
        static void Swap(ref int bednumber1, ref int bednumber2)
        {
            int temp = bednumber1;
            bednumber1 = bednumber2;
            bednumber2 = temp;
        }
        //2、将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
        //（1）、true/false，表示登陆是否成功
        //（2）、string，表示登陆失败的原因
        static void LogOn(out string username, out string password)
        {
            username = "源栈";
            password = "yz2354";
            Console.WriteLine("请输入用户名：");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("请输入密码：");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("恭喜！登录成功 ");
                }
                else
                {
                    Console.WriteLine("*密码错误*");
                }
            }
            else
            {
                Console.WriteLine("*用户名错误*");
            }
        }















































    }

}

