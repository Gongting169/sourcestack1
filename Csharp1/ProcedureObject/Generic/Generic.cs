using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.Generic
{
    public class Generic
    {
        //用泛型改造二分查找、堆栈和双向链表
        public static int Getnumber<T>(T[] binaryseek, T target) where T : IComparable
        {
            int left = 0;
            int right = binaryseek.Length - 1;
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (target.CompareTo(binaryseek[middle]) > 0)
                {
                    left = middle + 1;
                }
                else if (target.CompareTo(binaryseek[middle])< 0)
                {
                    right = middle - 1;
                }// target = middle
                else
                {
                    return middle;
                }
            }
            return -1;
        }

        public void Push<T>(T element, T[] container, int length)
        {
            int top = 0;
            if (top < container.Length)
            {
                container[top] = element;
                top++;
            }
            else
            {
                Console.WriteLine("栈以溢出");
            }
        }
        public Object Pop<T>(T[] container, int length)
        {
            container = new T[length];
            int top = 0;
            int bottom = 0;
            if (top != bottom)
            {
                top--;
                return container[top];
            }
            else
            {
                Console.WriteLine("栈以空");
                return -1;
            }
        }
        //用泛型改造“取数组中最大值”（提示：IComparable）
        public T GetMax<T>(T[] Array, T max) where T : IComparable
        {
            int i = 0;
            while (i < Array.Length)
            {
                if (max.CompareTo(Array[i]) < 0)
                {
                    max = Array[i];
                }//
                i++;
            }
            return max;
        }



    }
}
