
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


//点击回复评论的事件：
$('[yqbang-comment-reply]').click(function ()
{
    var $this = $(this),
        floor = $this.data('current-comment-layer'),
        text = $('[yqbang-comment-reply-location]').html(),
        varibleFloor = text.substring(text.indexOf("第"), text.indexOf("楼")).substring(1);
    if ($('[yqbang-comment-reply-location]').html().length === 0)
    {
        $('[yqbang-comment-reply-location]').append("--- 回复：第" + floor + "楼 ---");
        $('[yqbang-comment-reply-layer]').attr('href',`#${floor}`);
        $('[yqbang-comment-reply-location]').nextAll('input[name="commentId"]')
            .attr('value', `${$this.data('current-comment-id')}`);
    } else
    {
        if (varibleFloor !== floor)
        {
            $('[yqbang-comment-reply-location]').html("--- 回复：第" + floor + "楼 ---");

        } // else nothing
    }
})
//还是没有解决文章单页的时候，跑出来的页面评论无法显示正确的评论楼数
$('[yqbang-comment-reply-layer]').html(`第 ${$('[yqbang-comment-reply-layer]').attr('href').substring(1)} 楼`)


$('form').submit(function (event)
{
    event.preventDefault();
    var $thisSubmit = $(this);
    $.ajax({
        url: "/Article/PublishComment",
        method: "POST",
        data: $thisSubmit.serialize(),
        success: function (data)
        {
            var $data = $(data), $container = $('[yqbang-comments-container]');
            $data.mouseout(function ()
            {
                var $thisMouseOut = $(this);
                $thisMouseOut.css('background-color', 'aliceblue');
                $thisMouseOut.children().find('[yqbang-comment-hide]').attr('class', 'hide');
            });
            $data.mouseover(function ()
            {
                var $thisMouseOver = $(this);
                $thisMouseOver.css('background-color', 'white');
                $thisMouseOver.children().find('[yqbang-comment-hide]').attr('class', ' ');
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
            $data.find('[yqbang-comment-reply]').click(function ()
            {
                var $thisReply = $(this);
                if ($('[yqbang-comment-reply-location]').html().length === 0)
                {
                    $('[yqbang-comment-reply-location]').append("--- 回复：第" + $commentCout.html() + "楼 ---");
                    $('[yqbang-comment-reply-location]').nextAll('input[name="commentId"]')
                        .attr('value', `${$thisReply.data('current-comment-id')}`);
                } // else nothing 
            });
            $data.find('[yqbang-comment-reply-layer]').html($('[yqbang-comment-reply-location]').html().substring(7))
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











