using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureOriented
{
    class Array
    {
        //http://17bang.ren/Article/303
        //作业：C#面向过程：方法进阶：值/引用传递。
        //作业题目：1、利用ref调用Swap()方法交换两个同学的床位号
        //static void Swap(ref int bednumber1, ref int bednumber2)
        //{
        //    int temp = bednumber1;
        //    bednumber1 = bednumber2;
        //    bednumber2 = temp;
        //}
        //http://17bang.ren/Article/641
        //作业：C#方法进阶：参数： 重载/可选/params
        //作业题目:1、定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制： 
        //           最小值min（默认为1） 
        //           相邻两个元素之间的最大差值gap（默认为5）
        //    
        //http://17bang.ren/Article/294
        //作业：面向过程：数组
        //将源栈同学姓名 / 昵称分别： 
        //按进栈时间装入一维数组， 
        //按座位装入二维数组， 
        //并输出共有多少名同学。
        //static void GetCount()
        //{
        //    string[] name = new string[] { "刘伟——小刘", "李智博——小李", "周丁浩——小周", "龚廷义——小龚", "廖光银——小廖", "邹丽——小邹" };
        //    string[,] seatname = new string[4, 3];
        //    seatname[1, 0] = "刘伟——小伟";
        //    seatname[3, 0] = "龚廷义——小龚";
        //    seatname[0, 1] = "李智博——小李";
        //    seatname[1, 1] = "周丁浩——小周";
        //    seatname[2, 1] = "廖光银——小廖";
        //    seatname[0, 2] = "邹丽——小邹";
        //    Console.WriteLine(name.Length);
        //}

        //2、用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
        //static void GetName()
        //{
        //    string[] name = new string[] { "刘伟——小刘", "李智博——小李", "周丁浩——小周", "龚廷义——小龚", "廖光银——小廖", "邹丽——小邹" };
        //    string[,] seatname = new string[4, 3];
        //    for (int i = 0; i < name.Length; i++)//一维数组里取值
        //    {
        //        Console.WriteLine(name[i]);
        //        //}
        //        for (int i = 0; i < 4; i++)
        //        {
        //            for (int j = 0; j < 3; j++)
        //            {
        //                string s = seatname[i, j];
        //                Console.WriteLine(s);
        //            }
        //        }
        //    }
        //}

        //6、生成一个元素（值随机）从小到大排列的数组
        //static void GetRadom()
        //{
        //    int[] ascendarray = new int[10];
        //    Random value = new Random();
        //    ascendarray[0] = value.Next(5);
        //    for (int i = 1; i < 10; i++)
        //    {
        //        ascendarray[i] = value.Next(0, 100) + ascendarray[i - 1];
        //        Console.WriteLine(ascendarray[i]);
        //    }
        //}

        //7、设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()// 定义一个多维数组， 用for循环把数组的下标值相加起来是元素值
        //static void getelementvalue()
        //{
        //    int[,] add = new int[3, 4];
        //    for (int i = 0; i < add.getlength(0); i++)
        //    {
        //        for (int j = 0; j < add.getlength(1); j++)
        //        {
        //            console.write(i + j);
        //        }
        //        console.writeline();
        //    }
        //}

    }
}

