using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class MimicStack
    {
        //https://zhuanlan.zhihu.com/p/95261748 静态还是实例里面的作业：
        //5、自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
        //出栈Pop()，弹出栈顶数据
        //入栈Push()，可以一次性压入多个数据
        //出/入栈检查，
        //如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
        //如果已弹出所有数据，提示“栈已空”
        int[] stack = new int[10];
        int top = 0;
        int bottom = 0;
        public MimicStack( int length )
        {
           //stack  = length;
        }
        public int  push( int element)
        {
            if (top <= stack.Length -1)
            {
                top++;
                return top;
            }
            else
            {
                Console.WriteLine("栈溢出");
                return -1;
            }

        }






    }
}
