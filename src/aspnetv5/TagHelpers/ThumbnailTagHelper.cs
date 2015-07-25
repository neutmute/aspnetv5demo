using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagHelperDemo.TagHelpers
{
    /// <summary>
    /// http://www.codeproject.com/Articles/986917/Introducing-TagHelpers-with-ASP-NET-on-EverLeap
    /// </summary>
    [TargetElement("thumbnail", Attributes = "src")]
    public class ThumbnailTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes["class"] = "thumbnail";
            var sb = new StringBuilder();
            sb.AppendFormat("<img src=\"{0}\"", context.AllAttributes["src"].Value);
            if (context.AllAttributes.ContainsName("alt"))
            {
                sb.AppendFormat(" alt=\"{0}\"", context.AllAttributes["alt"]);
            }
            sb.Append("/>");
            if (context.AllAttributes.ContainsName("caption"))
            {
                sb.AppendFormat("<div class=\"caption\"><h3>{0}</h3></div>", context.AllAttributes["caption"].Value);
            }
            output.Content.SetContent(sb.ToString());

            base.Process(context, output);
        }
    }
}
