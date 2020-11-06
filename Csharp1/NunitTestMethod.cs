using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public static class NunitTestMethod
    {
        //https://zhuanlan.zhihu.com/p/94854332 争议TDD（测试驱动开发）
        //为之前作业添加单元测试，包括但不限于：
        //2、数组中找到最大值
        public static int GetMax(int[] Array)
        {
            int max = Array[0];
            int i = 1;
            while (i < Array.Length - 1)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                    i++;
                }// else continue;
            }
            return max;
        }

        //3、找到100以内的所有质数
        //public static int GetPrime(int start, int end, int[] )
        //{
        //    for (int i = 2; i < start; i++)
        //    {
        //        for (int j = 2; j < end; j++)
        //        {
        //            if (i % j == 0 && i != j)
        //            {
        //                break;
        //            }
        //            else if (i % j == 0 && i == j)
        //            {
        //                return i;
        //            }
        //            else
        //            {
        //                return -1;
        //            }
        //        }
        //    }
        //}
        //4、猜数字游戏
        //5、二分查找
        //6、栈的压入弹出




    }

}
