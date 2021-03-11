


///在邀请人这一栏输入，就可以得到一系列的用户名 已什么开头的用户
$(document).ready(function ()
{
    $('#InvitedByName').blur(function ()
    {
        var $this = $(this);
        console.log($this.val());
        $.ajax({
            url: "/Register/GetResult",
            method: "POST",
            data: { InvitedByName: $this.val() },
            
            beforeSend: function ()
            {

            },
            success: function (data)
            {
                var $data = $(data);
                console.log($data.serialize());
                console.log(data);
                

            },
            error: function ()
            {

            },
            complete: function ()
            {

            }
        })
  })
})
/// 验证码
$(document).ready(function ()
{
    $("#CaptchaCode").focus(function (event)//获得焦点，显示验证码
    {
        var $image = $("#imgCode");
        if ($image.is(":not([src])"))
        {
            $($image).attr("src", "/Register/ShowCode?key=" + Math.random()).show();
            $("[yqbang_refresh_captcha]").show();
            $("[yqbang_captcha_hide]").hide();
        }// else nothing
    });

    $("[yqbang_refresh_captcha]").click(function (event)//刷新验证码
    {
        event.preventDefault();
        $img = $("#imgCode");
        $img.attr("src", "/Register/ShowCode?refresh=1&key=" + Math.random());
    });
})





















