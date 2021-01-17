//http://17bang.ren/Article/481
//JavaScript：内置：包装 / 数组 / Math / Date 
//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：将“飞哥”改成“大神”，“线下”改成“线上”。
var string = "'源栈'：飞哥小班教学，线下免费收";
string.replace("飞哥", "大神");
string.replace("线下", "线上");
console.log(string);
//将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，让所有元素：
//首字母大写开头，其他字母小写
//截去超过6个字符的部分，如'community'将变成'Commun'
//使用正则表达式判断某个字符串:
//是否是合格的Email格式
//是否是小数（正负小数都可以）
//将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''，或者：<span>zyf---+---fyz</span> ……）
//利用新学到的Array函数，重新完成之前的数组相关作业
//在上述数组头部加上小鱼老师，末尾加上大飞哥
//创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于max的随机整数数组。
//生成一个函数toChinese() ，可将传入的日期参数（如：new Date() ）转换成中文日期格式（如：2019年10月4日 16点54分） 

