
//绑定事件：文章的点赞或者点踩弹出modal框
$(document).ready(function ()
{
    $('[yqbang-vote]').click(function ()
    {
        var $this = $(this),
            result = location.href.match(/\/\d*/gim),
            seek = $this.prop("href").match(/=\d*/gim);
        var id = result[result.length - 1].substring(1),
            agreeOrDisagree = seek[seek.length - 1].substring(1);
        $.ajax({
            url: "/Article/GetArticleUserInfo",
            method: "POST",
            data: `aId=${id}&direction=${agreeOrDisagree}`,
            success: function (data)
            {
                var sname = $('[yqbang-article-arthor]>*').text();
                if (data.CurrentUser === sname)
                {
                    $this.prop("data-target", "UnableAppraiseModal");
                }
                else
                {
                    $this.prop("data-target", "singleModal");
                }
                $('#singleModal').modal('show');
                $('[yqbang-votes-disagreecount]').html(data.AppraiseDownCount);
                $('[yqbang-votes-agreecount]').html(data.AppraiseUPCount);
                if ($('[yqbang-click-close]').attr("ckecked"))
                {
                    $this.removeAttr("data-target", "#singleModal");
                    $this.removeAttr("data-toggle", "modal");
                }// else nothing
            },
            error: function ()
            {

            }

        })
    });
})
//绑定事件： 文章打赏
$(document).ready(function ()
{
    $('[yqbang-article-donate-btn]').click(function ()
    {
        var $this = $(this);
        $('#mySingleModal').modal('show');

    })
})
//绑定事件:获取文章的上一篇和下一篇
$(document).ready(function ()
{
})



var a = /\/\d*/gim, result = location.href.match(a);

result[result.length - 1].substring(1)

$('[href]')[0]





