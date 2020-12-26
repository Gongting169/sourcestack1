using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureObject.Generic
{

    public class Generic
    {
        ////http://17bang.ren/Article/534 Lambda/匿名方法/闭包
        ////1、声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
        ////使用：  //方法 //匿名方法 //lambda表达式 //给上述委托赋值，并运行该委托
        ///// <summary>
        ///// 用方法给委托变量赋值
        ///// </summary>
        ///// <param name="person"></param>
        ///// <returns>返回的是int类型的值</returns>
        //public static int Add(Person person)
        //{       
        //    return person.Age++;
        //}
        ////声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
        //public static int GetWater(ProvideWater provideWater )
        //{
        //    Person person = new Person();
        //    return provideWater(person);
        //}

        //http://17bang.ren/Article/321  泛型的声明、约束、使用
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
                else if (target.CompareTo(binaryseek[middle]) < 0)
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

        //使用泛型改造双向链表

        //http://17bang.ren/Article/645 集合：foreach的背后
        //让之前的双向链表，能够：被foreach迭代



        //http://17bang.ren/Article/646   扩展方法：
        //调用扩展方法Max()：能够返回之前双向链表中存贮着最大值的节点





































    }


}
