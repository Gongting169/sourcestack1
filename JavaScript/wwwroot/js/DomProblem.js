

//模拟求助首页，并：
//统计有多少个悬赏大于1的求助
//var length = document.getElementsByClassName("status").length, count = 0;
//for (var i = 0; i < length; i++)
//{
//    var result = document.getElementsByClassName("status")[i].
//        getElementsByTagName("span")[4].innerText;
//    if (result > 1)
//    {
//        count++;
//    } // else nothing
//}
//console.log(count);
//将状态为“协助中”的求助背景改成灰黑色//就是这个状态还是整个求助为协助中
//document.getElementsByClassName("badge badge-pill badge-warning")[0].remove();
//var span = document.createElement('span');   
//span.style.backgroundColor = "#333";
//span.setAttribute("class","badge badge-pill badge-warning");
//var text = document.createTextNode('求助中');
//span.appendChild(text);
//document.getElementsByClassName("hide")[0]..appendChild(span);
//如果总结数为0，将其从DOM树中删除 删除的是0？ 还是整个包裹住的span标签
//var count = document.getElementsByClassName("status").length;
//for (var i = 0; i < count; i++)
//{
//    var result = document.getElementsByClassName("status")[i]
//        .lastElementChild.getElementsByTagName("span")[2].innerText;
//    if (result == 0)
//    {
//        document.getElementsByClassName("status")[i]
//            .lastElementChild.getElementsByTagName("span")[2].remove();//删除的是0的span标签和文本
//        //document.getElementsByClassName("status")[i]
//        //    .lastElementChild.getElementsByTagName("span")[2].innerText.remove();
//    }// else nothing
//}
//写一个函数getKeywordsCount() ，可以统计某个求助使用了多少关键字 一个求助对应多个关键字
//function getKeywordsCount()
//{
//    var keyword=[[],[],[]],count=0,length1 = document.getElementsByTagName("p").length;
//    for (var i = 0; i < length1; i++)
//    {
//        var length2 = document.getElementsByTagName("p")[i].getElementsByTagName("a").length;
//        for (var j = 0; j < length2; j++)
//        {
//            keyword[i][j] = document.getElementsByTagName("p")[i].getElementsByTagName("a")[j].innerText;
//            if (keyword.length >0)
//            {             
//                count++;
//            }//else nothing
//        }
//    }
//    console.log(keyword);
//    console.log(count);
//}
//参考用户注册页面，显示错误提示：
//密码的长度不能小于4
//密码和确认密码必须一致 

//参考用户资料页面，控制台显示出用户的：性别 / 出生年月 / 关注（关键字）/ 自我介绍
//性别：
//document.getElementsByName("gender")[0].checked;
//document.getElementsByName("gender")[1].checked;
////出生年月
//document.getElementsByName("BirthYear")[0].selectedOptions[0].innerText;
//document.getElementsByName("BirthMonth")[0].selectedOptions[0].innerText;
//document.getElementsByName("BirthConstellation")[0].selectedOptions[0].innerText;
////关键字
////document.getElementsByClassName("dropdown-menu")[0].selectedOptions[0].innerText;
////document.getElementsByClassName("dropdown-menu")[1].selectedOptions[0].innerText;
////自我介绍
//document.getElementsByName("self-introduction")[0].value;
//实现铃铛（没有学bootstrap的同学用文字代替）闪烁效果
//document.getElementsByTagName("i")[0].remove();
//var span = document.getElementsByClassName("navbar-text")[0].getElementsByTagName("span")[1],
//    tag = document.createElement("i"), text = document.createTextNode('');
//tag.setAttribute("class", "fa fa-bell fa-2x ml-3");
//tag.style.fontSize = "1.2rem";
//tag.setAttribute("aria-hidden", "true");
//tag.style.color = setInterval(function ()
//{
//    swap();
//}, 1000);
//tag.appendChild(text);
//span.after(tag);
//function swap()
//{
//    tag.style.color = tag.style.color == "darkblue" ? "lightblue" : "darkblue";
//}

