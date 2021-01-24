//http://17bang.ren/Article/481
//JavaScript：内置：包装 / 数组 / Math / Date 
//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：将“飞哥”改成“大神”，“线下”改成“线上”。
//var string = "'源栈'：飞哥小班教学，线下免费收";
//var result = string.replace("飞哥", "大神");
//console.log(result.replace("线下", "线上"));
//将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，让所有元素：
//首字母大写开头，其他字母小写
//截去超过6个字符的部分，如'community'将变成'Commun'
//var array = ['why', 'gIT', 'vs2019', 'community', 'VERSION'], char = [], newArray = [];
//for (var i = 0; i < array.length; i++)
//{
//    char[i] = array[i].substring(0, 6).toLocaleLowerCase();
//    newArray[i] = char[i].substr(0, 1).toLocaleUpperCase();
//}
//console.log(newArray);
//使用正则表达式判断某个字符串:
//是否是合格的Email格式
//是否是小数（正负小数都可以）
//将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''，或者：<span>zyf---+---fyz</span> ……）
//var regex = new regexp();
//利用新学到的Array函数，重新完成之前的数组相关作业
//删除一个数组里面重复的元素  // 要么全部删除，要么保留一个 
//var array = [15, 3, 6, 9, 3, 8, 7];
//for (var i = array.length - 1; i >= 0; i--)
//{
//    var value = array[i];
//    for (var j = 0; j < array.length - 1; j++)
//    {
//        if (value == array[j]) 有问题 为什么会是一个？
//        {
//            array.splice(j, 1);
//        }// else nothing
//    }
//}
//console.log(array);
//完成冒泡排序
//var array = [32, 8, 17, 56, 73, 2, 19];
//array.sort(function (a, b) {
//    return a > b ? 1 : -1;
//});
//console.log(array);
//在上述数组头部加上小鱼老师，末尾加上大飞哥
//array.unshift("小鱼老师");
//array.push("大飞哥");
//console.log(array);
//创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于max的随机整数数组。
//function getRandomArray(length, max)
//{
//    var array = [];
//    for (var i = 0; i < Math.floor((Math.random() * length)); i++)
//    {
//        array[i] = Math.floor((Math.random() * max));     
//    }
//    return array;
//}
//生成一个函数toChinese() ，可将传入的日期参数（如：new Date() ）转换成中文日期格式（如：2019年10月4日 16点54分） 
//var date = new Date("2020/8/7 15:32");传参日期格式
//function toChinese(date)
//{
//    var newDate = date.getFullYear() + "年"
//        + (date.getMonth() + 1) + "月"
//        + date.getDate() + "日"
//        + date.getHours() + "点"
//        + date.getMinutes() + "分";
//    return newDate;
//}

//生成一个函数addDays(number) ，可在当前日期的基础上增加number天 

//function addDays(number)
//{
//    var date = new Date();
//    date.setDate(date.getDate() + number);
//   return date;
//}

