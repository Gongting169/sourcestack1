using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class MimicStack : Entity
    {
        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //5、自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
        //出栈Pop()，弹出栈顶数据
        //入栈Push()，可以一次性压入多个数据
        //出/入栈检查，
        //如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
        //如果已弹出所有数据，提示“栈已空”
        Object[] Container;
        int top = 0;
        const int bottom = 0;
        public MimicStack(int length)
        {
            Container = new object[length];
        }
        public void push(params Object[] element)
        {
            for (int i = 0; i < element.Length - 1; i++)
            {
                if (top <= this.Container.Length - 1)
                {
                    this.Container[top] = element[i];
                    top++;
                }
                else
                {
                    Console.WriteLine("栈溢出");
                }
            }
        }
        public object pop()
        {
            if (top != bottom)
            {
                top--;
                return Container[top];
            }
            else
            {
                Console.WriteLine("栈以空");
                return -1;
            }
        }

        //https://zhuanlan.zhihu.com/p/93458057 万物皆对象：Object拆箱和装箱里面的作业：
        //使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素
    }
}
