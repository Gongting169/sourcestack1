using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static int BinarySeek()
        {
            int[] seek = { 20, 25, 32, 46, 50, 62, 76, 81, 96, 99 };
            int target = 25;
            int right = seek.Length - 1;
            int left = 0;
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (seek[left] == target)
                {
                    Console.WriteLine(left);
                    break;
                }
                else if (seek[right] == target)
                {
                    Console.WriteLine(right);
                    break;
                }
                else if (target < seek[middle])
                {
                    right = middle;
                }
                else if (target > seek[middle])
                {
                    left = middle;
                }
                else // target == seek[middle]
                {
                    Console.WriteLine(middle);
                    break;
                }
            }
            return 1;
        }
        //6、栈的压入弹出

        public static int push(int element, int Length)
        {
            int[] Container = new int[Length];
            int top = 0;
            for (int i = 0; i < Container.Length - 1; i++)
            {
                if (top <= Container.Length)
                {
                    Container[top] = element;
                    top++;
                }
                else
                {
                    Console.WriteLine("栈以溢出");
                }
            }
            return 1;
        }


        public static int pop()
        {
            int top = 0;
            int bottom = 0;
            if (top != bottom)
            {
                top--;
                return top;
            }
            else
            {
                Console.WriteLine("栈以空");
                return -1;

            }

        }

    }

}
