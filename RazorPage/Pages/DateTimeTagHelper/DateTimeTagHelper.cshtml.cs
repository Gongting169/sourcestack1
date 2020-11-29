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
            //�ֱ�ȡ��pageIndex��path��ֵ
            object pageIndex = context.AllAttributes["pageIndex"].Value;
            //output.Attributes.Remove(context.AllAttributes["pageIndex"]);

            object path = context.AllAttributes["path"].Value;
            //output.Attributes.RemoveAll("path");

            //����a��ǩ��href��ֵ
            output.Attributes.Add("href", $"{path}/Page-{pageIndex}");

            output.TagName = "small";
            output.Content.AppendHtml(DateTime.Now.ToString("yyyy��MM��dd��hh��mm��"));
            base.Process(context, output);
        }

    }
}
