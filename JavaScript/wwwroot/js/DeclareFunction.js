
//http://17bang.ren/Article/482
//JavaScript：函数 / 方法：声明和调用 里面的作业
//作业（二）
//将之前“找出素数”的代码封装成一个函数findPrime(max) ，可以打印出max以内的所有素数。
//function findPrime(max)
//{
//    for (var i = 2; i < max; i++)
//    {
//        for (var j = 2; j <= max; j++)
//        {
//            if (i % j == 0)
//            {
//                break;
//            } else if (i - 1 == j)
//            {
//                console.log(i);
//            }
//        }
//    }
//}
//自行设计参数，将之前“累加求和”的代码封装成一个函数Sum() ，可以计算任意起始位置、任意步长（如：1, 3, 5……或者0, 5, 10, 15……）的等差数列之和。
//function sum(start, n, stepLength)
//{
//    var sum = 0, value;
//    for (var i = 0; i < n; i++)
//    {
//        value = start + i * stepLength;
//        sum = sum + value;
//    }
//    return sum;
//}
//封装一个函数，建立一个函数getMaxNumber() ，可以接受任意多各种类型（整数、小数、正数、负数、字符串、布尔值等）的参数，并找出里面最大的数（忽略其他类型）
//function getMaxNumber() {
//    var max = 0, result;
//    for (var i = 0; i < arguments.length - 1; i++) {
//        if (isNaN(arguments[i])) {
//            if (Number.parseInt(arguments[i]) > 0) {
//                result = arguments[i];
//            } //else nothing
//        }
//        else {
//            if (arguments[i] < arguments[i + 1]) {
//                max = arguments[i + 1];
//            }// else nothing
//        }
//        max = result > max ? max : result;       
//    }
//    return max;
//}
//封装一个函数Swap(arr, i, j) ，可以交换数组arr里下标 i 和 j 的值
//function Swap( array,i, j)
//{
//    var temp = array[i];
//    array[i] = array[j];
//    array[j] = temp;
//}
//利用上面的Swap()函数，将“冒泡排序”封装成函数bubbleSort()
//function bubbleSort(array)
//{
//    for (var i = 0; i < array.length; i++)
//    {
//        for (var j = 0; j < array.length - i; j++)
//        {
//            if (array[j] > array[j + 1])
//            {
//                Swap(array, j, (j+1));
//            }// else nothing
//        }
//    }
//}
//删除一个数组里面重复的元素
//function deleteDuplicated(array)
//{
//    var newArray = [];
//    for (var i = 0; i < array.length - 1; i++)
//    {
//        if (array[i] === array[array.length - i])
//        {
//            continue;
//        } else
//        {
//            newArray[i] = array[i];
//        }
//    }
//}
//创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于max的随机整数数组。
//function getRandomArray(length, max)
//{
//    var array = [];
//    for (var i = 0; i < Math.floor(Math.random() * length); i++)
//    {
//            array[i] = Math.floor((Math.random() * max));
//    }
//    return array;
//}
//不使用JavaScript内置函数，将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。还可以利用下标来做
//function reverse() {
//    var string = 'hello,yuanzhan', value = '';
//    for (var i = string.length - 1; i >= 0; i--)
//    {
//        value = value + string[j];
//    }
//    console.log(value);
//}

//统计出这段文字中有多少个单词：
//var words = `There are two ways to create a RegExp object: a literal notation and a constructor.To indicate strings,
//the parameters to the literal notation do not use quotation marks while the parameters to the constructor
//function do use quotation - marks.So the following expressions create the same regular expression `
//function statisticsCount()
//{
//    var count = 0;
//    words += " ";
//    for (var i = 0; i < words.length; i++)
//    {
//        if (!isAlpha(words[i]))
//        {
//            if (isAlpha(words[i - 1]))
//            {
//                count++;
//            }//else continue
//        }//else continue
//    }
//    console.log(count);
//}
//function isAlpha(theChar)
//{
//    return (theChar >= "a" && theChar <= "z" || theChar >= "A" && theChar <= "Z")

//}
