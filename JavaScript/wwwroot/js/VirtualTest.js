//http://17bang.ren/Article/482
//JavaScript：函数 / 方法：声明和调用 里面的作业
//作业一
//开始使用伪单元测试，
//将每天 / 课的作业用不同的js文件分隔：
//构建一个函数has9(number) ，可以判断number中是否带有数字9；（19 / 98）
//function  has9(number)
//{
//    var result = `${number}`.includes("9", `${number}`.indexOf("9")) == true ? true : false;
//    return result;
//}
//构建一个函数has8(number) ，可以判断number中是否带有数字8；
//function has8(number) {
//    while (number > 0) {
//        if (number % 10 == 8) {
//            return true;
//        }
//        number = Math.trunc(number / 10);//trunc是取整数
//    }
//    return false;
//}
//构建一个函数has6(number) ，可以判断number中是否带有数字6；
//function has6(number) {
//    while (number > 0) {
//        if (number % 10 == 8) {
//            return true;
//        }
//        number = Math.trunc(number / 10);//trunc是取整数
//    }
//    return false;
//}
//使用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
//function getCountNumber() {
//    for (var i = 1; i < 10000; i++)
//    {
//        if (has9(i))
//        {
//            console.log(i);
//        } else if (has8(i))
//        {
//            console.log(i);
//        }
//        else if (has6(i))
//        {
//            console.log(i);
//        }
//    }
//}
//让get986()通过调用has9() / has8() / has6() ，能找出number以内有多少个数字包含：9或者8或6。
//function get986( number)
//{
//    for (var i = 1; i < number; i++)
//    {
//        if (has9(i))
//        {
//            console.log(i);
//        } else if (has8(i))
//        {
//            console.log(i);
//        }
//        else if (has6(i))
//        {
//            console.log(i]);
//        }              
//    }    
//}