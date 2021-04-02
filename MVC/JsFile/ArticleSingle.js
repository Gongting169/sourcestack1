
//绑定事件：文章的点赞或者点踩弹出modal框
$(document).ready(function ()
{
    $('[yqbang-vote]').click(function ()
    {
        var $this = $(this),
            result = location.href.match(/\/\d*/gim),
            seek = $this.prop("href").match(/=\d*/gim);
        $.ajax({
            url: "/Article/GetArticleUserInfo",
            method: "POST",
            data: `aId=${result[result.length - 1].substring(1)}&direction=${seek[seek.length - 1].substring(1)}`,
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
                $('[yqbang-votes-disagreecount]').html(data.DownCount);
                $('[yqbang-votes-agreecount]').html(data.UPCount);
                if ($('[yqbang-click-close]').attr("ckecked"))
                {
                    $this.removeAttr("data-target", "#singleModal");
                    $this.removeAttr("data-toggle", "modal");
                }// else nothing
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

//绑定事件：文章的评论 
$('form').submit(function (event)
{
    var $this = $(this), html = editor.html(), result = location.href.match(/\/\d*/gim);
    $.ajax({
        url: "/Article/PublishComment",
        method: "POST",
        data: `html=${html}&aId=${result[result.length - 1].substring(1)}`,
        beforeSend: function ()
        {
            event.preventDefault();
        },
        success: function (data)
        {
            var amount = $('[yqbang-comment-count]').text(), $data = $(data)
                , $container = $('[yqbang-comments-container]');
            if (amount > 1)
            {
                $container.prop("data-target", "#CommentModal");
                $('#CommentModal').modal('show');
                $data.prependTo($container);
            }// else nothing 
        },
        error: function (jqXHR, textStatus, errorThrown)
        {
            console.log(jqXHR);
            console.log(textStatus);
            console.log(errorThrown);
        },
        complete: function ()
        {
            ''.replace(' ', editor.html());
        }
    })
})

//文章单页、评论部分回复、支持和反对等事件
//鼠标移入事件：移入背景颜色变化和显示回复
$('[yqbang-problem-comment]').mouseover(function ()
{
    var $this = $(this);
    $this.css('background-color', 'white');
    $this.children().find('[yqbang-comment-hide]').attr('class', ' ');
})
//鼠标移出事件：移出背景颜色和回复消失
$('[yqbang-problem-comment]').mouseout(function ()
{
    var $this = $(this);
    $this.css('background-color', 'aliceblue');
    $this.children().find('[yqbang-comment-hide]').attr('class', 'hide');
})

//在支持和反对上绑定事件















