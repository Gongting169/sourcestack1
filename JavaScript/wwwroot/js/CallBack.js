//http://17bang.ren/Article/483
//JavaScript：回调函数 
//yz.fei.get(number, handler)除number以外，还可以接受任意多个回调函数handler做参数，得到：0到number间有多少个满足handler条件的整数。
//1、回调函数handler能对number进行运算，并返回bool值的，比如has6()
//2、get()函数调用回调函数进行运算，只要回调函数运行结果为真，就累加计数
//3、最后返回累加值
//var yz = {};
//yz.fei = {};
//yz.fei.get = function (number, func)
//{
//    var result;
//    for (var i = 1; i < number; i++)
//    {
//        while (func(i))//func里面可以添加多个hanlder作为参数，而由16行到18行的代码
//        {
//            result += 1;
//            console.log(i);
//        }
//    }
//    return result;
//}
//yz.fei.get(10, handler);
//function handler(number)
//{
//    return (number + '').toString().indexOf("6") > -1;
//}
////让yz.fei.get(number)调用实现之前“统计含9 / 8 / 6数字个数”的作业
//yz.fei.get = function (number)
//{
//    var count = 0;
//    if (has9(number) || has8(number) || has6(number))
//    {
//        count++;
//    }
//    return count;
//}


