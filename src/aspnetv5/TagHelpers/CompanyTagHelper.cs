using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using AspNetDemo.Models;
using Microsoft.AspNet.Razor.TagHelpers;
using SteelCap.Extensions;

namespace AspNetDemo.TagHelpers
{
    /// <summary>
    /// http://www.mikesdotnetting.com/article/275/custom-taghelpers-in-asp-net-mvc-6
    /// </summary>
    public class CompanyTagHelper : TagHelper
    {
        public Organisation Organisation { get; set; }

        /// <summary>
        /// This doesn't get populated
        /// </summary>
        public List<Organisation> ManyOrganisations { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var br = new TagBuilder("br");
            br.TagRenderMode = TagRenderMode.SelfClosing;
            
            output.TagName = "div";
            output.Attributes.Add("itemscope", null);
            output.Attributes.Add("itemtype", "http://schema.org/Organization");

            var name = new TagBuilder("span");
            name.MergeAttribute("itemprop", "name");
            name.InnerHtml.Append(Organisation.Name);

            var address = new TagBuilder("address");
            address.MergeAttribute("itemprop", "address");
            address.MergeAttribute("itemscope", null);
            address.MergeAttribute("itemtype", "http://schema.org/PostalAddress");

            var span = new TagBuilder("span");
            span.MergeAttribute("itemprop", "streetAddress");
            span.InnerHtml.Append(Organisation.StreetAddress);
            address.InnerHtml.Append(br);

            span = new TagBuilder("span");
            span.MergeAttribute("itemprop", "addressLocality");
            span.InnerHtml.Append(Organisation.AddressLocality);

            address.InnerHtml.Append(span);
            address.InnerHtml.Append(br);

            span = new TagBuilder("span");
            span.MergeAttribute("itemprop", "addressRegion");
            span.InnerHtml.Append(Organisation.AddressRegion);

            address.InnerHtml.Append(span);

            span = new TagBuilder("span");
            span.MergeAttribute("itemprop", "postalCode");
            span.InnerHtml.Append(Organisation.PostalCode);

            address.InnerHtml.Append(span);
            
            output.Content.Clear();
            output.Content.Append(address);
        }
    }
}
