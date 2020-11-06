using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureOriented
{
    class SeekNumber
    {
        //1、找到100以内的所有质数（只能被1和它自己整除的数
        //static void GetPrime()
        //{
        //    for (int i = 2; i <= 100; i++)
        //    {
        //        for (int j = 2; j < i; j++)
        //        {
        //            if (i % j == 0)
        //            {
        //                break;
        //            }
        //            else if (i - 1 == j)
        //            {
        //                Console.WriteLine(i);
        //            }//else nothing
        //        }
        //    }
        //}
        //2、在一个数组中寻找最小的值
        //static double GetMin(double[] score)
        //{
        //    double min = score[0];
        //    for (int i = 1; i < score.Length; i++)
        //    {
        //        if (score[i] < min)
        //        {
        //            min = score[i];
        //        } // else continue;
        //    }
        //    return min;
        //}
        //3、在一个数组中寻找最大的值：
        //static double GetMax(double[] score)
        //{
        //    double max = score[0];
        //    for (int i = 1; i < score.Length; i++)
        //    {
        //        if (score[i] > max)
        //        {
        //            max = score[i];
        //        } // else continue ;
        //    }
        //    return max;
        //}
        //4、计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        ///
        //static double GetAverage(double[] score)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < score.Length; i++)
        //    {
        //        sum = sum + score[i];
        //    }
        //    double average = sum / score.Length;
        //    return Math.Round(average, 2);
        //}

        //5、完成“猜数字”游戏，方法名GuessMe()：
        //随机生成一个大于0小于1000的整数
        //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了” 
        //没猜中可以继续猜，但最多不能超过10次         //具体的思路：应该要把用户的输入值给考虑到位，如果出现不符合要求的输入值怎么办？
        //如果5次之内猜中，输出：你真牛逼！            
        //如果8次之内猜中，输出：不错嘛！ 
        //10次还没猜中，输出：(～￣(OO)￣)ブ 

        //6、让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
        //static void GetSum()
        //{
        //    int sum = 0;
        //    for (int i = 1; i< 100; i += 2)
        //    {
        //        sum += i;
        //    }
        //console.writeline(sum);
        //}


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


    }
}
