
using CSharplearn.ProcedureObject.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public struct Prove
    {
        //https://zhuanlan.zhihu.com/p/94590192
        //面向对象：结构和日期里面的作业：
        //1、用代码证明struct定义的类型是值类型
        //public static int age = null;
        public static int age1 = 32;
        public static int i = 18;
        public static int j = i;

        //源栈的学费是按周计费的，所以请实现这两个功能：
        //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期  
        public DateTime GetDate(DateTime day, int count, Unit unit)
        {
            switch (unit)
            {
                case Unit.day:
                    day = day.AddDays(count);
                    break;

                case Unit.month:
                    day = day.AddMonths(count);
                    break;

                case Unit.week:
                    day = day.AddDays(count * 7);
                    break;

                default:
                    Console.WriteLine("有异常");
                    break;
            }
            return day;
        }
        //给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
     


    }
}
