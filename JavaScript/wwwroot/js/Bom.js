
//http://17bang.ren/Article/486
//JavaScript：BOM：window对象 / 导航 / 定时器 / 其他 
//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；（Math.floor(Math.random() * 1000) ）
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^
function guessMe()//有两种情况。要么就猜中，要么就猜不中
{
    var random = Math.floor(Math.random() * 1000);
    window.confirm("游戏玩法说明：");
    for (var i = 0; i < 11; i++)
    {

    }

}
//    分别使用setInterval()使用setTimeout()实现：每隔1秒钟依次显示：第n周，源栈同学random人。（n逐次递增，random随机）
