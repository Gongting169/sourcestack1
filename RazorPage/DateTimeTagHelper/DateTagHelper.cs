using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.DateTimeTagHelper
{
    [HtmlTargetElement("datetime", Attributes = "pageIndex,path")]
    public class DateTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";
            //分别取出pageIndex和path的值
            object pageIndex = context.AllAttributes["pageIndex"].Value;
            output.Attributes.Remove(context.AllAttributes["pageIndex"]);

            object path = context.AllAttributes["path"].Value;
            output.Attributes.RemoveAll("path");

            //设置a标签里href的值
            output.Attributes.Add("href", $"{path}/Page-{pageIndex}");
            output.Content.AppendHtml(DateTime.Now.Date.ToString("yyyy年MM月dd日"));
            base.Process(context, output);
        }
    }
}
