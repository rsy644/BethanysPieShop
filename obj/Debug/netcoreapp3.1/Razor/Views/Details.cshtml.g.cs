#pragma checksum "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83edb328162dc6447ad250662ebde795bd9ededb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details), @"mvc.1.0.view", @"/Views/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83edb328162dc6447ad250662ebde795bd9ededb", @"/Views/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93580ec8c15385cc678dfcc140d1272591ff58e7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            BeginWriteAttribute("alt", " alt=\"", 194, "\"", 211, 1);
#nullable restore
#line 10 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
WriteAttributeValue("", 200, Model.Name, 200, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 212, "\"", 233, 1);
#nullable restore
#line 10 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
WriteAttributeValue("", 218, Model.ImageUrl, 218, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
#nullable restore
#line 12 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
#nullable restore
#line 14 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </h3>\r\n        <h4>");
#nullable restore
#line 16 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>");
#nullable restore
#line 17 "C:\Users\USER\source\repos\BethanysPieShop\BethanysPieShop\Views\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
