using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace sourcestack1.Pages.DateTimeTagHelper
{
    public class DateTimeTagHelperModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    [HtmlTargetElement("datetime")]
    public class DateTimeTagHelper :TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //分别取出pageIndex和path的值
            object pageIndex = context.AllAttributes["pageIndex"].Value;
            //output.Attributes.Remove(context.AllAttributes["pageIndex"]);

            object path = context.AllAttributes["path"].Value;
            //output.Attributes.RemoveAll("path");

            //设置a标签里href的值
            output.Attributes.Add("href", $"{path}/Page-{pageIndex}");

            output.TagName = "small";
            output.Content.AppendHtml(DateTime.Now.ToString("yyyy年MM月dd日hh点mm分"));
            base.Process(context, output);
        }

    }
}
