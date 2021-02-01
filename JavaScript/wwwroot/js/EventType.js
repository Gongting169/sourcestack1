
//1、参考求助首页侧边栏关键字，实现：当鼠标移动到关键字上，显示关键字被使用次数
//var length = document.getElementsByClassName("user-tags")[0].getElementsByTagName("a").length;
//for (var i = 0; i < length; i++)
//{
//    document.getElementsByClassName("user-tags")[0]
//        .getElementsByTagName("a")[i].addEventListener("mouseover", showKeywordsUseCount);
//}
//function showKeywordsUseCount()
//{
//    this.title = `已使用${Math.floor(Math.random() * 1000)}次`; //这个背景颜色怎么写？有差异：不是在关键字的上方显示 次数要从数据库里面取
//}
//2、参考一起帮首页，实现右侧漂浮并底对齐左侧文本框的效果  没做出来
//var scrollHeight1 = document.documentElement.scrollHeight, //文档实际高度
//    clientHeight1 = document.documentElement.clientHeight;  //框架本身高度
//window.onscroll = float;
//function float()
//{
//    console.log(document.documentElement.scrollTop);
//        if (document.documentElement.scrollTop > 300)
//        {
//            document.getElementById("ad-chats").style.top  == document.documentElement.scrollTop;
//        }
//        else if (scrollHeight1 - clientHeight1 == document.documentElement.scrollTop)
//        {
//            document.getElementById("ad-chats").style.height == clientHeight1 + document.documentElement.scrollTop;
//        }
//}
//$('[ad-chats]').css('top', 20);
//$(document).scroll(function ()
//{
//    var top = $(document).scrollTop();
//    if (top < 380)
//    {
//        top = 20;
//    }
//    else
//    {
//        top = 500 - top;
//    }
//    $('[ad-chats]').css('top', top);
//})
//3、参考消息页面：完成勾选全选功能
for (var i = 0; i < 2; i++)
{
    document.getElementsByClassName("checkbox-inline")[i].onclick = selecteAll;
}
function selecteAll()
{
    var length = document.getElementsByClassName("row text-bold").length;
    for (var i = 0; i < length; i++)
    {
        document.getElementsByClassName("row text-bold")[i].getElementsByTagName("input")[0].checked = true;
    }
}
//for (var j = 0; j < 2; j++)
//{
//    document.getElementsByClassName("checkbox-inline")[j].onclick = cancelAll;//取消选择
//}
//function cancelAll()
//{
//    var length = document.getElementsByClassName("row text-bold").length;
//    for (var i = 0; i < length; i++)
//    {
//        document.getElementsByClassName("row text-bold")[i].getElementsByTagName("input")[0].checked = false;
//    }
//}
//4、参考注册页面：
//提交时，如果用户名重复（已有用户名用数组保存），阻止form提交，提示“用户名重复”。
//重新输入用户名，一旦输入用户名部分没有重复，“用户名重复”的提示消失
//当用户名或密码等有值时，关闭页面前弹出确认框


//5、参考求助首页侧边栏“免费广告发布”弹出Modal，实现（不需要弹出Modal）：
//根据下拉列表选中项，填充“文字内容”和“链接”文本框
//勾选修改的checkbox，实现“文字内容”和“链接”文本框的禁用和启用
//6、参考发布求助，实现其关键字功能：
//没有选择一级关键字，不能选择二级关键字
//选择一级关键字后，二级关键字只能是一级关键字下的子集
//一级关键字和二级关键字被选中后，会显示在下拉列表上方
//自定义关键字输入完成后（按空格键），输入的关键字显示在下拉列表上方
//后输入的关键字显示在前面 
