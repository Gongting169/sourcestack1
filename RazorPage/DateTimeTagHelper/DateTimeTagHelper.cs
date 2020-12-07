using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Pages.DateTimeTagHelper
{
    [HtmlTargetElement("datetime", Attributes = "asp-only,asp-showicon")]
    public class DateTimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";
            //分别取出pageIndex和path的值
            object pageIndex = context.AllAttributes["asp-only"].Value;
            output.Attributes.Remove(context.AllAttributes["asp-only"]);
            object path = context.AllAttributes["asp-showicon"].Value;
            output.Attributes.RemoveAll("asp-showicon");
            //设置a标签里href的值
            output.Attributes.Add("href", $"{path}/Page-{pageIndex}");
            base.Process(context, output);
        }
    }
}