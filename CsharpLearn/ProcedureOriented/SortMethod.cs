using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.ProcedureOriented
{
    class SortMethod
    {
        //10、布置的作业：快速排序
        //static void quickSort(int[] src, int left, int right)//有bug，当有相等值时，会报越界错误。
        //{
        //    int oldleft = left;
        //    int oldright = right;
        //    int middle = left;
        //    int middlevalue = src[left];
        //    if (left >= right)
        //    {
        //        return;
        //    }
        //    while (left < right)
        //    {    //从右往左
        //        while (right > middle)
        //        {
        //            if (src[right] < middlevalue)
        //            {
        //                Swap(src, middle, right);
        //                middle = right;
        //                break;
        //            }
        //            right--;
        //        }
        //        while (left < middle)
        //        {   //从左往右
        //            if (src[left] > middlevalue)
        //            {
        //                Swap(src, middle, left);
        //                middle = left;
        //                break;
        //            }
        //            left++;
        //        }
        //    }
        //    quickSort(src, oldleft, middle - 1);
        //    quickSort(src, middle + 1, oldright);
        //}
        //static void Swap(int[] src, int middle, int right)
        //{
        //    int temp = src[middle];
        //    src[middle] = src[right];
        //    src[right] = temp;
        //}
        //第二种快排的写法：
        //static void QuickSort(int[] array, int left, int right)
        //{
        //    if (left >= right)
        //    {
        //        return;
        //    }
        //    int middle = array[left];
        //    int l = left, r = right;

        //    while (l < r)
        //    {
        //        while (l < r)
        //        {
        //            if (middle <= array[r])
        //            {
        //                r--;
        //            }
        //            if (middle > array[r])
        //            {
        //                Swap(array, l, r);
        //                break;
        //            }
        //        }
        //        while (l < r)
        //        {
        //            if (array[l] <= middle)
        //            {
        //                l++;
        //            }
        //            if (array[l] > middle)
        //            {
        //                Swap(array, l, r);
        //                break;
        //            }
        //        }
        //    }

        //    QuickSort(array, left, r - 1);
        //    QuickSort(array, l + 1, right);
        //}

        //8、循环：布置的作业二分查找：
        //题目：如何在一个有序的数组中查找某个元素。
        //static void binarysearch()
        //{
        //    int[] seek = { 20, 25, 32, 46, 50, 62, 76, 81, 96, 99 };
        //    int target = 25;
        //    int right = seek.length - 1;
        //    int left = 0;
        //    int middle;
        //    while (left <= right)
        //    {
        //        middle = (left + right) / 2;
        //        if (seek[left] == target)
        //        {
        //            console.writeline(left);
        //            break;
        //        }
        //        else if (seek[right] == target)
        //        {
        //            console.writeline(right);
        //            break;
        //        }
        //        else if (target < seek[middle])
        //        {
        //            right = middle;
        //        }
        //        else if (target > seek[middle])
        //        {
        //            left = middle;
        //        }
        //        else // target == seek[middle]
        //        {
        //            console.writeline(middle);
        //            break;
        //        }
        //    }
        //}

        //http://17bang.ren/Article/641
        //作业：C#方法进阶：参数： 重载/可选/params
        //2、实现二分查找，方法名BinarySeek(int[] numbers, int target)： 
        //传入一个有序（从大到小/从小到大）数组和数组中要查找的元素
        //如果找到，返回该元素所在的下标；否则，返回-1 


    }
}
