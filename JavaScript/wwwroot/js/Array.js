//声明一个数组odds，利用循环把100以内的奇数按从小到大的顺序存入其中
//var odds = [];
//for (var i = 0; i < 50; i++) {
//    odds[i] = (2 * i) + 1;
//}
//计算从odds数组中所有元素的和
//var sum = 0, i = 0;
//while (i < odds.length) {
//    sum = sum + odds[i];
//    i++;
//}
//console.log(sum);
//找到数组中的最小值
//var i = 1,
//    array = [15, 27, 3, 1, 5, 8, 16, 29, 37],
//    min = array[0];
//while (i < array.length) {
//    if (min > array[i]) {
//        min = array[i];
//    } //else nothing
//    i++;
//}
//console.log(min);
//去除一个数组中重复的值（提示：仔细思考需求）要么全部删除，要么保留
//var array = [1, 3, 5, 3, 5, 6, 7, 8, 9], n = 2 //n不等于1，小于array.length-1 ;
//for (var i = 0; i < array.length; i++)
//{

//}
//输出用空格代替0的杨辉三角形
//var rows = 5,
//    columns = rows * 2 - 1;
//var yh = [];
//for (var i = 0; i < rows; i++) {
//    yh[i] = [];
//    var lines = '';
//    for (var j = 0; j < columns; j++) {
//        if (i == 0) {
//            yh[i][j] = (j == rows - 1) ? 1 : ' ';
//        } else {
//            var preRow = i - 1,
//                preColumn = j - 1 >= 0 ? yh[preRow][j - 1] : 0,
//                nextColumn = j + 1 < columns ? yh[preRow][j + 1] : 0;
//            var current = preColumn + nextColumn;
//            yh[i][j] = current ? current : ' ';
//        }
//        lines += yh[i][j] + ' ';
//    }
//    console.log(lines);
//}
//输出1000以内的所有“素数 / 质数”（只能被自己和1整除的数）
//for (var i = 2; i <= 100; i++) {
//    for (var j = 2; j <= i; j++) {
//        if (i % j == 0 && i != j) {
//            break;
//        }
//        else if (i % j == 0 && i == j) {
//            console.log(i);
//        }
//    }
//}
//完成冒泡排序（必做，参考C#）
//var array = [15, 34, 65, 78, 3, 26, 19, 49, 56, 82, 9],
//    temp = 0;
//for (var i = 0; i < array.length; i++) {
//    for (var j = 0; j < array.length - i; j++) {
//        if (array[j] > array[j + 1]) {
//            temp = array[j];
//            array[j] = array[j + 1];
//            array[j + 1] = temp;
//        } //else nothing
//    }
//}
//for (var i = 0; i < array.length; i++) {
//    console.log(array[i]);
//}
//完成：二分查找 / 快速排序（选做，参考C#）
//var binary = [5, 19, 24, 37, 48, 56, 61, 75, 84, 96, 105],
//    target = 96,
//    left = 0,
//    right = binary.length - 1;
//while (left <= right) {
//    var middle = Math.floor((left + right) / 2);
//    if (target > binary[middle]) {
//        left = middle + 1;
//    }
//    else if (target < binary[middle]) {
//        right = middle - 1;
//    } else {
//        console.log(middle);
//        break;
//    }
//}
//快速排序

//var array = [15, 9, 26, 1, 37, 8, 69, 78, 5],
//    left = 0,
//    right = array.length - 1,
//    oldLeft = 0,
//    oldRight = 0,
//    middle = 0;
//while (left < right)
//{
//    if (true) {

//    }

//    if (true) {

//    }
//}


