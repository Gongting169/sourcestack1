
//http://17bang.ren/Article/486
//JavaScript：BOM：window对象 / 导航 / 定时器 / 其他 
//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；（Math.floor(Math.random() * 1000) ）
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！ 包不包含第6的那一次啊
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^
function guessMe()//有两种情况。要么就猜中，要么就猜不中
{
    var random = Math.floor(Math.random() * 1000), isConfirm =
        window.confirm("游戏玩法说明：您输入一个大于0,小于1000的整数与系统进行匹配,最后会输出相应的提示信息");
    //input还有个问题是小数呢？ 首先要判断输入是否符合要求
    if (isConfirm)
    {
        for (var i = 1; i < 11; i++)
        {
            var input = Number.parseInt(window.prompt());
            if (input < 0 || input >= 1000)
            {
                 alert("请正确的输入一个整数值0到1000之间");
            }
            if (!input)
            {
                 alert("请按照提示信息，输入正确的数字");
            }
            if (random > input)
            {
                alert("您输入的值小了");
            }
            else if (input > random)
            {
                alert("您输入的值大了");
            }
            else if (input === random && i >= 8 )
            {
                alert("猜到了");
                return;
            }
            else if (input === random && i < 8 && i >= 6)
            {
                alert("666");
                return;
            }
            else if (input === random && i < 6)
            {
                alert("碉堡了");
                return;
            }
            else if (input !== random && i === 10)// 这是一次都没有猜中的情况
            {
                alert("^ (*￣(oo) ￣)^");
                return;
            }
        }
    }
    else
    {
        alert("您是否选择离开此页面？");
        return;
    }
}
//    分别使用setInterval()使用setTimeout()实现：每隔1秒钟依次显示：第n周，源栈同学random人。（n逐次递增，random随机）
//var i = 1;
//setInterval(function ()
//{
//    console.log('第' + (i++) + '周,源栈同学' + Math.floor(Math.random() * 100) + '人');
//}, 1000);
//setTimeout(function run()
//{
//    console.log('第' + (i++) + '周,源栈同学' + Math.floor(Math.random() * 100) + '人');
//    setTimeout(run, 1000);
//}, 1000);
