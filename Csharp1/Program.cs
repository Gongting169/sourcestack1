﻿
using CSharplearn;
using CSharplearn.ProcedureObject.Enum;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace CSharplearn
{
    public class Program : Entity<int>
    {
        static void Main(string[] args)
        {             
            //https://zhuanlan.zhihu.com/p/93747718 string还是stringBuilder里面的作业：调用
            Console.WriteLine(Stringbuilder.GetCount("ashjbvjbkvhaihiwqifbkafkvjzbha", "a"));
            //https://zhuanlan.zhihu.com/p/93458057 万物皆对象：Object拆箱和装箱里面的作业：
            //在https://source.dot.net/中查看源代码，了解为什么 Console.WriteLine(new Student()); 会输出Student类名//static Equal () 方法 判断两个对象相不相等
            //思考dynamic和var的区别，并用代码予以演示
            //int a = 18;
            //string b = "fg";
            //var c = a;
            //var d = b;
            ////Console.WriteLine(c -d );
            //dynamic gty = "yz";
            //Console.WriteLine(gty -23);//dynamic会避开编译时的检查，但运行时会报错。var不行
            //构造一个能装任何数据的数组，并完成数据的读写
            dynamic[] dfg = new dynamic[] { 23, "fg", true, false, 85.96 };
            for (int i = 0; i < dfg.Length; i++)
            {
                Console.WriteLine(dfg[i]);
            }

            //https://zhuanlan.zhihu.com/p/93440022 面向对象：反射和特性里面的作业
            //4、用反射获取Publish()上的特性实例，输出其中包含的信息
            Attribute attribute1 = HelpMoneyChangedAttribute.GetCustomAttribute
              (typeof(ContentService).GetMethod("Publish", BindingFlags.Public | BindingFlags.Instance)
              , typeof(HelpMoneyChangedAttribute));

            Attribute attribute2 = HelpMoneyChangedAttribute.GetCustomAttribute
                (typeof(Problem).GetMethod("Publish", BindingFlags.Public | BindingFlags.Instance)
                , typeof(HelpMoneyChangedAttribute));

            Console.WriteLine(((HelpMoneyChangedAttribute)attribute1).Amount);
            Console.WriteLine(((HelpMoneyChangedAttribute)attribute2).Amount);
            //https://zhuanlan.zhihu.com/p/93440022 面向对象：反射和特性里面的作业
            //面向对象：反射和特性里面作业的调用：
            Content content = new Suggest("zl");//仅是为了调用content变量中的createtime和publishtime

            ContentCreateTime contentCreateTime = new ContentCreateTime();
            contentCreateTime.ChangeTime(content, new DateTime(2020, 9, 1), new DateTime(2019, 8, 27));
            Console.WriteLine(content.createTime);
            Console.WriteLine(content.PublishTime);
            //https://zhuanlan.zhihu.com/p/94590192
            //面向对象：结构和日期里面的作业：
            //1、用代码证明struct定义的类型是值类型
            Console.WriteLine(Prove.j);
            //2、Getdate()的调用：
            DateTime date = new DateTime(2019, 1, 8);
            Prove prove = new Prove();
            Console.WriteLine(prove.GetDate(date, 8, Unit.week));
            //https://zhuanlan.zhihu.com/p/94590467 不一样的权限管理：枚举和位运算的作业：
            //2、声明一个令牌管理（TokenManager）类：
            //使用私有的Token枚举_tokens存储所具有的权限
            //User gty = new User("12", "35");
            //gty.Tokens = new TokenManager();
            //gty.Tokens.Add(Token.Admin);
            //gty.Tokens.Add(Token.Blogger);
            //gty.Tokens.Remove(Token.Admin);
            //Console.WriteLine(gty.Tokens._tokens);

            //http://17bang.ren/Article/299
            //调用函数的作业：
            //作业：方法基础： 声明/调用/返回值
            //第1小题的调用：
            //Console.WriteLine(GetSum(1)); 
            //if (LogOnyqbang("ut91", "yezi", "1234", out string reason))
            //{
            //    Console.WriteLine(reason);
            //}
            //else
            //{
            //    Console.WriteLine(reason);
            //}
            //double[] score = { 76.52, 68.76, 99.6, 85.9, 65.8, 48.5, 100.3 };
            //Console.WriteLine( GetMax(score));
            //Console.WriteLine(GetMin(score ));
            //快速排序的调用：
            //int[] src = { 35, 2, 16, 52, 36, 15, 3, 4, 37, 53, 49 };
            //quickSort(src, 0, 10);
            //QuickSort(src, 0, src.Length - 1);
            //for (int i = 0; i < src.Length; i++)
            //{
            //    Console.WriteLine(src[i]);
            //}

            //第2小题的调用：
            //double[] score = { 76.52, 68.76, 99.6, 85.9, 65.8, 48.5 };
            ////Console.WriteLine(GetAverage(score));
            //http://17bang.ren/Article/303
            //作业：C#面向过程：方法进阶：值/引用传递。
            //第1小题的调用：
            //int bednumber1 = 202, bednumber2 = 203;
            //Swap(ref bednumber1, ref bednumber2);
            ////第2小题的调用：
            //if (LogOn("ut91","yezi","1234",out string reason))
            //{
            //    Console.WriteLine(reason);
            //}
            //else
            //{
            //    Console.WriteLine(reason);
            //}
            Console.WriteLine();

        }
    }
}


