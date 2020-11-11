using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;

namespace CSharplearn
{
    public class Generic<T>
    {
        //用泛型改造二分查找、堆栈和双向链表
        public void Getnumber()
        {
            int[] binaryseek = { 1, 3, 7, 12, 21, 35, 65, 78 };
            int left = 0;
            int right = binaryseek.Length - 1;
            int middle = (left + right) / 2;
            int target = 35;
            while (left < right)
            {
                if (binaryseek[left] <= target)
                {
                    Console.WriteLine(left);
                }
                else if (binaryseek[right] >= target)
                {
                    Console.WriteLine(right);
                }
                else if (binaryseek[middle] < target)
                {
                    left = middle;
                }
                else if (binaryseek[middle] > target)
                {
                    right = middle;
                }// target = middle
                {
                    Console.WriteLine(middle);
                }
            }
        }

        public void Push(int element)
        {
            int[] container = new int[10];
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
        public void Pop()
        {
            int[] container = new int[10];
            int top = 0;
            int bottom = 0;
            if (top != bottom)
            {
                top--;
            }
            else
            {
                Console.WriteLine("栈以空");
            }
        }

    }
}
