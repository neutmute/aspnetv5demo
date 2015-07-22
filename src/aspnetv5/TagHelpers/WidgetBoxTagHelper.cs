using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Mvc.TagHelpers;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace aspnetv5.TagHelpers
{
    [TargetElement("widget-box")]
    public class WidgetTagHelper : TagHelper
    {
        public string Title { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var outerTag = new TagBuilder("div");
            outerTag.Attributes.Add("class", output.TagName);
            output.MergeAttributes(outerTag);
            output.TagName = outerTag.TagName;

            //Create the header
            var header = new TagBuilder("div");
            header.Attributes.Add("class", "widget-header");
            header.InnerHtml = this.Title;
            output.PreContent.SetContent(header.ToHtmlString(TagRenderMode.Normal).ToString());
            
            //Create the body and replace original tag helper content
            var body = new TagBuilder("div");
            body.Attributes.Add("class", "widget-body");
            var originalContents = await context.GetChildContentAsync();
            body.InnerHtml = originalContents.GetContent();
            output.Content.SetContent(body.ToHtmlString(TagRenderMode.Normal).ToString());
        }
    }
}
