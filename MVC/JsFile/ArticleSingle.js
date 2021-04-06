
//绑定事件：文章的点赞或者点踩弹出modal框
$(document).ready(function ()
{
    $('[yqbang-article-vote]').click(function (event)
    {
        event.preventDefault();
        var $this = $(this), authorId = $('[yqbang-article-author]').data('author-id'),
            cookieId = document.cookie.substring(document.cookie.indexOf("Id="), document.cookie.indexOf('&'));
        if (isNaN(cookieId[cookieId.length - 1]))
        {
            return;
        }
        if (authorId === parseInt(cookieId[cookieId.length - 1]))
        {
            $('#UnableAppraiseModal').modal('show');
            return;
        }
        else
        {
            $.ajax({
                url: $this.attr('href'),
                method: "GET",
                cache: false,
                success: function (data)
                {
                    $this.find('[yqbang-votes-count]').html(data);
                    $('#singleModal').modal('show');
                },
                error: function (jqXHR, textStatus, errorThrown)
                {
                    console.log(jqXHR);
                    console.log(textStatus);
                    console.log(errorThrown);
                }
            })
        }
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


//绑定事件：文章的评论 
$('form').submit(function (event)
{
    event.preventDefault();
    var $this = $(this), html = editor.html(), result = location.href.match(/\/\d*/gim);
    $.ajax({
        url: "/Article/PublishComment",
        method: "POST",
        data: `html=${html}&aId=${result[result.length - 1].substring(1)}`,
        success: function (data)
        {
            var $data = $(data), $container = $('[yqbang-comments-container]');
            $data.mouseout(function ()
            {
                var $this = $(this);
                $this.css('background-color', 'aliceblue');
                $this.children().find('[yqbang-comment-hide]').attr('class', 'hide');
            });
            $data.mouseover(function ()
            {
                var $this = $(this);
                $this.css('background-color', 'white');
                $this.children().find('[yqbang-comment-hide]').attr('class', ' ');
            });
            $('#CommentModal').modal('show');
            $data.prependTo($container);
            var $floor = $data.children().find('[yqbang-reply-location]'),
                $commentCout = $data.parents().parents().find('[yqbang-comment-count]');
            if ($commentCout.html() === '0')
            {
                $floor.html("--- 第 1 楼 ---");
            }
            else
            {
                $floor.html(`--- 第 ${+$commentCout.html() + 1} 楼 ---`);
            }
            $commentCout.html(`${+$commentCout.html() + 1}`);
        },
        error: function (jqXHR, textStatus, errorThrown)
        {
            console.log(jqXHR);
            console.log(textStatus);
            console.log(errorThrown);
        },
        complete: function ()
        {
            editor.html('');
        }
    })
})


//能够回复别人的事件：
$('[yqbang-comment-reply]').click(function (event)
{
    event.preventDefault();
    var $this = $(this), floor = $this.data('current-comment-layer');
    $('[yqbang-reply-location]').append("--- 回复：第" + floor + "楼 ---");
    $.ajax({
        url: "/Article/_CommentReply",
        method: "POST",
        data: $('form').serialize(),
        success: function (data)
        {
            var $data = $(data);
        }

    })
})


//在支持和反对上绑定事件
$('[yqbang-comment-vote]').click(function (event)
{
    event.preventDefault();
    var $this = $(this), authorId = $this.data('author-id'),
        cookieId = document.cookie.substring(document.cookie.indexOf("Id="), document.cookie.indexOf('&'));
    if (isNaN(cookieId[cookieId.length - 1]))
    {
        return;
    }
    if (authorId === parseInt(cookieId[cookieId.length - 1]))
    {
        $('#UnableAppraiseModal').modal('show');
        return;
    }
    else
    {
        $.ajax({
            url: $this.attr('href'),
            method: "GET",
            cache: false,
            success: function (data)
            {
                $this.find('[yqbang-votes-count]').html(data);
                $('#singleModal').modal('show');
            },
            error: function (jqXHR, textStatus, errorThrown)
            {
                console.log(jqXHR);
                console.log(textStatus);
                console.log(errorThrown);
            }
        })
    }
})














