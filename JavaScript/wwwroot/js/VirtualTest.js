//http://17bang.ren/Article/482
//JavaScript：函数 / 方法：声明和调用 里面的作业
//作业一
//开始使用伪单元测试，
//将每天 / 课的作业用不同的js文件分隔：
//构建一个函数has9(number) ，可以判断number中是否带有数字9；（19 / 98）万一number是个负数，小数 ？
//function has9(number)
//{
//    return (number + '').toString().indexOf("9") > -1;
//}
////构建一个函数has8(number) ，可以判断number中是否带有数字8；
//function has8(number)
//{
//    return (number + '').toString().indexOf("8") > -1;
//}
////构建一个函数has6(number) ，可以判断number中是否带有数字6；
//function has6(number)
//{
//    return (number + '').toString().indexOf("8") > -1;
//}
////使用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
//function getCountNumber()
//{
//    var count = 0;
//    for (var i = 1; i < 10000; i++)
//    {
//        if (has9(i) || has8(i) || has6(i))
//        {
//            count++;
//        }//else nothing
//    }
//    return count;
//}
////让get986()通过调用has9() / has8() / has6() ，能找出number以内有多少个数字包含：9或者8或6。
//function get986(number)
//{
//    var count = 0;
//    for (var i = 1; i < number; i++)
//    {
//        if (has9(i) || has8(i) || has6(i))
//        {
//            count++;
//        }// else nothing
//    }
//    return count;
//}