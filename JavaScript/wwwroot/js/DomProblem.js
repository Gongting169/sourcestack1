

//模拟求助首页，并：
//统计有多少个悬赏大于1的求助
//var length = document.getElementsByClassName("status").length, count = 0;
//for (var i = 0; i < length; i++)
//{
//    var result = parseInt(document.getElementsByClassName("status")[i].
//        getElementsByTagName("span")[4].innerText);
//    if (result > 1)
//    {
//        count++;
//    } // else nothing
//}
//console.log(count);
//将状态为“协助中”的求助背景改成灰黑色//就是这个状态还是整个求助为协助中
//var length = document.getElementsByName("status").length;
//for (var i = 0; i < length; i++)
//{
//    var result = document.getElementsByName("status")[i].getElementsByTagName("span")[0].innerText
//    if (result === "协助中")
//    {
//        document.getElementsByName("status")[i].
//            getElementsByTagName("span")[0].style.backgroundColor = "rgba(51,51,51,0.96875)";
//        //document.getElementsByName("status")[i].parentElement.style.backgroundColor="rgba(51,51,51,0.96875)";整个求助改为灰黑色
//    }
//}
//如果总结数为0，将其从DOM树中删除 删除的是0？ 还是整个包裹住的span标签
//var count = document.getElementsByClassName("status").length;
//for (var i = 0; i < count; i++)
//{
//    var result = document.getElementsByClassName("status")[i]
//        .lastElementChild.getElementsByTagName("span")[2].innerText;
//    if (result == 0)
//    {
//        //document.getElementsByClassName("status")[i]
//        //    .lastElementChild.remove();//删除的是整个span标签和文本总结和0
//        document.getElementsByClassName("status")[i]
//            .lastElementChild.getElementsByTagName("span")[2].remove();
//    }// else nothing
//}
//写一个函数getKeywordsCount() ，可以统计某个求助使用了多少关键字 一个求助对应多个关键字
//var problem = document.getElementsByTagName("p")[0];
//function getKeywordsCount(problem)
//{
//    var keyword = [], count = 0,length = problem.getElementsByTagName("a").length;
//    for (var i = 0; i < length; i++)
//    {
//        keyword[i] = problem.getElementsByTagName("a")[i].innerText;
//        if (keyword[i].length > 0)
//        {
//            count++;
//        }//else nothing
//    }
//    console.log(keyword);
//    console.log(count);
//}
//参考用户注册页面，显示错误提示：
//密码的长度不能小于4
//var password = document.getElementsByName("Password")[0];
//if (password.value.length < 4)
//{
//    alert("密码的长度不能小于4");
//}
//密码和确认密码必须一致
//var password = document.getElementsByName("Password")[0];
//var confirmpassword = document.getElementsByName("ConfirmPassword")[0];
//if (password.value != confirmpassword.value)
//{
//    alert("密码和确认密码必须一致");
//}
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
//var target = document.getElementsByTagName("i")[0];
//function swap()
//{
//    target.style.color = target.style.color === "darkblue" ? "lightblue" : "darkblue";
//}
//target.style.color = setInterval(function ()
//{
//    swap();
//}, 1000);

