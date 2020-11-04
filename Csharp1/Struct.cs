using Csharp1;
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
        public static bool GetWeek(int year, int index, out DateTime first, out DateTime last)
        {
            first = DateTime.MinValue;
            last = DateTime.MinValue;
            if (year < 1700 || year > 9999)
            {
                return false;//"年份超限"
            }
            if (index < 1 || index > 53)
            {
                return false; //"周数错误"
            }
            DateTime startDay = new DateTime(year, 1, 1);  //该年第一天
            DateTime endDay = new DateTime(year + 1, 1, 1).AddMilliseconds(-1);
            int dayOfWeek = Convert.ToInt32(startDay.DayOfWeek);  //该年第一天为星期几
            if (index == 1)
            {
                first = startDay;
                if (dayOfWeek == 6)
                {
                    last = first;
                }
                else
                {
                    last = startDay.AddDays((6 - dayOfWeek));
                }
            }
            else
            {
                first = startDay.AddDays((7 - dayOfWeek) + (index - 2) * 7); //index周的起始日期
                last = first.AddDays(6);
                if (last > endDay)
                {
                    last = endDay;
                }//else nothing
            }
            if (first > endDay)  //startDayOfWeeks不在该年范围内
            {
                //"输入周数大于本年最大周数";
                return false;
            }//else nothing
            return true;
        }


    }
}
