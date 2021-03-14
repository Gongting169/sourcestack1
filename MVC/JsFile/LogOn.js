

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