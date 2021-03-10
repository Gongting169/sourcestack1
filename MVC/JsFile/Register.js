
$(document).ready(
    function ()
    {
        $('#UserName').change(function ()
        {
            var sname = this.value;

            $.ajax({
                url: "/Register/Home",
                method: "Post",
                beforeSend: function (event)
                {

                },
                success: function (data)
                {
                },
                error: function (jqxhR, textStatus, errorThrown)
                {
                    console.log(jqxhR);
                    console.log(textStatus);
                    console.log(errorThrown);
                }
            });
        })
    })























