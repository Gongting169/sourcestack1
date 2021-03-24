
//绑定事件：文章的点赞或者点踩弹出modal框
$(document).ready(function ()
{
    $('[yqbang-vote]').click(function ()
    {
        var $this = $(this);
        $('#mySingleModal').modal('show');
        if ( $('[yqbang-click-close]').attr("ckecked"))
        {
            $this.removeAttr("data-target", "#singleModal");
            $this.removeAttr("data-toggle", "modal");
        }// else nothing
        $.ajax({
            url:"/Article/"

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



