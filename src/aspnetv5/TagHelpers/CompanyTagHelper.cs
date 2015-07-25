using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetDemo.Models;

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
            var br = new TagBuilder("br").ToString(TagRenderMode.SelfClosing);
            output.TagName = "div";
            output.Attributes.Add("itemscope", null);
            output.Attributes.Add("itemtype", "http://schema.org/Organization");
            var name = new TagBuilder("span");
            name.MergeAttribute("itemprop", "name");
            name.SetInnerText(Organisation.Name);
            var address = new TagBuilder("address");
            address.MergeAttribute("itemprop", "address");
            address.MergeAttribute("itemscope", null);
            address.MergeAttribute("itemtype", "http://schema.org/PostalAddress");
            var span = new TagBuilder("span");
            span.MergeAttribute("itemprop", "streetAddress");
            span.SetInnerText(Organisation.StreetAddress);
            address.InnerHtml = span.ToString() + br;
            span = new TagBuilder("span");
            span.MergeAttribute("itemprop", "addressLocality");
            span.SetInnerText(Organisation.AddressLocality);
            address.InnerHtml += span.ToString() + br;
            span = new TagBuilder("span");
            span.MergeAttribute("itemprop", "addressRegion");
            span.SetInnerText(Organisation.AddressRegion);
            address.InnerHtml += span.ToString();
            span = new TagBuilder("span");
            span.MergeAttribute("itemprop", "postalCode");
            span.SetInnerText($" {Organisation.PostalCode}");
            address.InnerHtml += span.ToString();
            output.Content.SetContent(name.ToString() + address.ToString());
        }
    }
}
