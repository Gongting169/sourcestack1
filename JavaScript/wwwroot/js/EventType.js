//1、参考求助首页侧边栏关键字，实现：当鼠标移动到关键字上，显示关键字被使用次数  显示的位置不对
//var length = document.getElementsByClassName("user-tags")[0].getElementsByTagName("a").length;
//for (var i = 0; i < length; i++)
//{
//    document.getElementsByClassName("user-tags")[0]
//        .getElementsByTagName("a")[i].addEventListener("mouseover", showkeywordsUseCount);
//    document.getElementsByClassName("user-tags")[0]
//        .getElementsByTagName("a")[i].addEventListener("mouseout", disappearUseCount);
//}
//function showkeywordsUseCount()
//{
//    var tag = document.createElement("span");
//    tag.style = "background - color: black; color: floralwhite;";
//    tag.style = "position:relative; top : -20px; left:55px;";
//    var text = document.createTextNode(`已使用${Math.floor(Math.random() * 1000)}次`);
//    tag.appendChild(text);
//    this.appendChild(tag);
//}
//function disappearUseCount()
//{

//}
//2、参考一起帮首页，实现右侧漂浮并底对齐左侧文本框的效果
//window.onscroll = float;
//function float()
//{
//    var top = window.pageYOffset || document.documentElement.scrollTop || document.body.scrollTop || 0;
//    if (top < 200)
//    {
//        document.getElementById("ad-chats").style.top = 200;
//    }
//    else
//    {
//        if (document.getElementById("chat-container").scrollHeight >( document.getElementById("ad-chats").scrollHeight +top))
//        {
//            document.getElementById("ad-chats").style.top = document.getElementById("chat-container").scrollHeight;
//        }// else nothing       
//    }
//}
//3、参考消息页面：完成勾选全选功能
//for (var i = 0; i < 2; i++)
//{
//    document.getElementsByClassName("checkbox-inline")[i].onclick = selecteAll;
//}
//function selecteAll()
//{
//    var length = document.getElementsByClassName("row text-bold").length;
//    for (var i = 0; i < length; i++)
//    {
//        if (document.getElementsByClassName("checkbox-inline")[0].children[0].checked === true)
//        {
//            document.getElementsByClassName("row text-bold")[i].getElementsByTagName("input")[0].checked = true;
//        }
//        else
//        {
//            document.getElementsByClassName("row text-bold")[i].getElementsByTagName("input")[0].checked = false;
//        }
//    }
//}
//4、参考注册页面：
//提交时，如果用户名重复（已有用户名用数组保存），阻止form提交，提示“用户名重复”。
//document.getElementsByTagName("form")[0].onsubmit = function (event)
//{
//    event.preventDefault();
//    repeat();
//}
//function repeat()
//{
//    var sname = document.getElementsByClassName("form-control")[2].value, userName = ["你真好", "真不错", "天很蓝"];
//    for (var i = 0; i < userName.length; i++)
//    {
//        if (sname === userName[i])
//        {
//            var tag = document.createElement("span");
//            tag.style.backgroundColor = "red";
//            var text = document.createTextNode("* 用户名重复，请重新输入")
//            tag.appendChild(text);
//            document.getElementsByClassName("form-control")[2].nextElementSibling.appendChild(tag);
//        }//else nothing 
//    }
//}
//重新输入用户名，一旦输入用户名部分没有重复，“用户名重复”的提示消失
//document.getElementsByClassName("form-control")[2].onkeyup = disappear;
//function disappear()
//{
//    var sname = document.getElementsByClassName("form-control")[2].value, userName = ["你真好", "真不错", "天很蓝"];
//    for (var i = 0; i < userName.length; i++)
//    {
//        if (sname === userName[i])
//        {
//            var tag = document.createElement("span");
//            tag.style.backgroundColor = "red";
//            var text = document.createTextNode("* 用户名重复，请重新输入")
//            tag.appendChild(text);
//            document.getElementsByClassName("form-control")[2].nextElementSibling.appendChild(tag);
//            return false;
//        }
//        else if (document.getElementsByClassName("form-control")[2].nextElementSibling.innerText.length > 0)
//        {
//            document.getElementsByClassName("form-control")[2].nextElementSibling.remove();
//        }// else nothing 
//    }
//}
//当用户名或密码等有值时，关闭页面前弹出确认框
//window.onbeforeunload = leaveConfirm;
//function leaveConfirm()
//{
//    var userName = document.getElementsByClassName("form-control")[2].value,
//        password = document.getElementsByClassName("form-control")[3].value;
//    if (userName.length > 0 || password.length >0)
//    {
//        return "确定是否离开当前页面";
//    }// else nothing
//}
//5、参考求助首页侧边栏“免费广告发布”弹出Modal，实现（不需要弹出Modal）：
//根据下拉列表选中项，填充“文字内容”和“链接”文本框
//var length = document.getElementsByClassName("nav flex-column")[0].getElementsByClassName("nav-link").length;
//for (var i = 0; i < length; i++)
//{
//    document.getElementsByClassName("nav flex-column")[0]
//        .getElementsByClassName("nav-link")[i].setAttribute("data-toggle", "modal");
//    document.getElementsByClassName("nav flex-column")[0]
//        .getElementsByClassName("nav-link")[i].setAttribute("data-target", "#myModal");
//}
//var length1 = document.getElementsByClassName("modal-body")[0]
//    .getElementsByTagName("option").length;
//for (var j = 0; j < length; j++)
//{
//    if (document.getElementsByClassName("modal-body")[0].getElementsByTagName("option")[j].selected)
//    {
//        var text = document.getElementsByClassName("modal-body")[0].getElementsByTagName("option")[j].text,
//           url= document.getElementsByClassName("modal-body")[0].getElementsByTagName("option")[j];
//        //document.getElementsByClassName("modal-body")[0]
//        //    .getElementsByClassName("form-control")[1].appendChild(text);
//    }//esle nothing 
//}
//勾选修改的checkbox，实现“文字内容”和“链接”文本框的禁用和启用
//document.getElementsByClassName("modal-body")[0]
//    .getElementsByClassName("pull-right")[1].getElementsByTagName("input")[0].onclick = unenable;
//function unenable()
//{
//    var link = document.getElementsByClassName("modal-body")[0]
//        .getElementsByClassName("form-control")[2],
//        character = document.getElementsByClassName("modal-body")[0]
//            .getElementsByClassName("form-control")[1];
//    if (this.checked)
//    {
//        character.setAttribute("readonly", "readonly");
//        link.setAttribute("readonly", "readonly");
//    } else
//    {
//        character.removeAttribute("readonly", "readonly")
//        link.removeAttribute("readonly", "readonly");
//    }
//}
//6、参考发布求助，实现其关键字功能：
//没有选择一级关键字，不能选择二级关键字
//document.getElementsByClassName("btn btn-outline-secondary dropdown-toggle")[1].onclick = choose;
//function choose()
//{
//    if (document.getElementById("Keywords").children[0] === undefined)
//    {
//        this.setAttribute("data-toggle", "modal");
//        this.setAttribute("data-target", "#myModal");
//    }
//    else
//    {
//        this.setAttribute("data-toggle", "dropdown")
//        this.removeAttribute("data-toggle", "modal")
//        this.removeAttribute("data-target", "#myModal")
//    }
//}
//选择一级关键字后，二级关键字只能是一级关键字下的子集
//一级关键字和二级关键字被选中后，会显示在下拉列表上方
var length = document.getElementsByClassName("input-group-prepend")[0]
    .getElementsByClassName("dropdown-menu")[0]
    .getElementsByTagName("li").length;
for (var i = 0; i < length; i++)
{
    document.getElementsByClassName("input-group-prepend")[0]
        .getElementsByClassName("dropdown-menu")[0]
        .getElementsByTagName("li")[i].onclick = firstShowTop;
}
function firstShowTop()
{
    var spanTag = document.createElement("span")
        , fontAwsomeTag = document.createElement("span")
        , smallTag = document.createElement("small")
        , text = document.createTextNode(this.innerText);
    spanTag.style = "margin - right: 5px";
    spanTag.setAttribute("class", "badge badge-pill badge-dark");
    smallTag.style = "margin-left:5px;";
    fontAwsomeTag.setAttribute("class", "fa fa-times");
    spanTag.appendChild(text);
    spanTag.appendChild(smallTag);
    smallTag.appendChild(fontAwsomeTag);
    document.getElementById("Keywords").appendChild(spanTag);  
}
var length1 = document.getElementsByClassName("input-group-append")[0]
    .getElementsByClassName("dropdown-menu")[0]
    .getElementsByTagName("li").length;
for (var j = 0; j < length1; j++)
{
    document.getElementsByClassName("input-group-append")[0]
        .getElementsByClassName("dropdown-menu")[0]
        .getElementsByTagName("li")[j].onclick = secondShowTop;
}
function secondShowTop()
{
    var spanTag = document.createElement("span")
        , fontAwsomeTag = document.createElement("span")
        , smallTag = document.createElement("small")
        , text = document.createTextNode(this.innerText);
    spanTag.style = "margin - right: 5px";
    spanTag.setAttribute("class", "badge badge-pill badge-dark");
    smallTag.style = "margin-left:5px;";
    fontAwsomeTag.setAttribute("class", "fa fa-times");
    spanTag.appendChild(text);
    spanTag.appendChild(smallTag);
    smallTag.appendChild(fontAwsomeTag);
    document.getElementById("Keywords").appendChild(spanTag);  
}
//自定义关键字输入完成后（按空格键），输入的关键字显示在下拉列表上方
document.getElementsByClassName("form-control")[0].onkeydown = myselfDefine;
function myselfDefine(event)
{
    if (event.keyCode === 32)
    {
        var spanTag = document.createElement("span")
            , fontAwsomeTag = document.createElement("span")
            , smallTag = document.createElement("small")
            , text = document.createTextNode(this.value);
        spanTag.style = "margin - right: 5px";
        spanTag.setAttribute("class", "badge badge-pill badge-dark");
        smallTag.style = "margin-left:5px;";
        fontAwsomeTag.setAttribute("class", "fa fa-times");
        spanTag.appendChild(text);
        spanTag.appendChild(smallTag);
        smallTag.appendChild(fontAwsomeTag);
        document.getElementById("Keywords").appendChild(spanTag);
        this.value = "  ";
    }
}
//后输入的关键字显示在前面 









