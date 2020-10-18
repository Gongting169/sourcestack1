using System;

namespace SelfStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组的冒泡排序；
            //int[] sort = { 132, 35, 26, 3, 18, 22, 16, 45, 53, 62, 7 };
            //        for (int i = 1; i < sort.Length; i++)  // 第二轮查找
            //        {
            //            for (int j = 0; j < sort.Length - i; j++) // 第一轮查找
            //            {
            //                if (sort[j] > sort[j + 1])
            //                {
            //                   int  temp = sort[j];
            //                    sort[j] = sort[j + 1];
            //                    sort[j + 1] = temp; 
            //                }
            //            }
            //        }
            //为什么要在外面套一层for循环：因为第一轮查找是进行第一轮排序，如果在里面套for循环的话，如果没有包含住if条件语句，没有达到排序的目的，只是进行了循环，所以这是不行的
            //如果在里面嵌套一层for循环包含住if条件语句，就是进行第二轮循环，操作起来稍微麻烦一点没有必要申明多的变量（变量可以省，不会有太大的用处，可有可无）
            //前面的树大于后面的数就可以直接得出结果。外循环的次数不变，但内循环的次数-i，减少的是内循环查找完几次，外循环就减少几次查找。   
            //生成一个元素（值随机）从小到大排列的数组
            //int[] nums = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = random.Next(0, 100);
            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = i + 1; j < 10; j++)
            //    {
            //        if (nums[j] < nums[i])
            //        {
            //            int temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //}
            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.Read();










        }
    }
}

