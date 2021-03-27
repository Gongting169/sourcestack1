

$(document).ready(function ()
{
    setInterval(swap, 1000);
})

function swap()
{
    var bell = $("[yqBang-bell]")[0].style;
    if (bell.color != 'lightblue')
    {
        bell.color = 'lightblue';
    }
    else
    {
        bell.color = 'darkblue';
    }

}





