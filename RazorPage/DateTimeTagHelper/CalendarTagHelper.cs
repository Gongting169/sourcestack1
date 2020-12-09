using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.DateTimeTagHelper
{
    [HtmlTargetElement("datetime", Attributes = "asp-showicon,asp-only")]
    public class CalendarTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";

            if (Convert.ToBoolean( context.AllAttributes["asp-showicon"].Value.ToString()))
            {
                output.PreContent.AppendHtml(" <span class=\" fa fa - calendar\"></span>");
            }
            if (Convert.ToBoolean(context.AllAttributes["asp-only"].Value.ToString()))
            {
                output.Content.AppendHtml(Convert.ToDateTime(output.GetChildContentAsync().Result.GetContent()).ToString("yyyy年MM月dd日"));
            }
            output.Attributes.Remove(context.AllAttributes["asp-showicon"]);
            output.Attributes.RemoveAll("asp-only");
            base.Process(context, output);
        }
    }
}
