#pragma checksum "C:\Users\Stephen.P\Documents\Projects 2020~\RazorPagesPerosnalWebsite\Pages\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6796dc73fd339bdb840a58e704d42b8cee140e21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesPerosnalWebsite.Pages.Pages_Success), @"mvc.1.0.razor-page", @"/Pages/Success.cshtml")]
namespace RazorPagesPerosnalWebsite.Pages
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
#line 1 "C:\Users\Stephen.P\Documents\Projects 2020~\RazorPagesPerosnalWebsite\Pages\_ViewImports.cshtml"
using RazorPagesPerosnalWebsite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6796dc73fd339bdb840a58e704d42b8cee140e21", @"/Pages/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1fb7eb721e77e32246a93215cb886fd5d59164d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Success : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Stephen.P\Documents\Projects 2020~\RazorPagesPerosnalWebsite\Pages\Success.cshtml"
  
    ViewData["Title"] = "Sucess!";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Stephen.P\Documents\Projects 2020~\RazorPagesPerosnalWebsite\Pages\Success.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesPerosnalWebsite.Pages.SuccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesPerosnalWebsite.Pages.SuccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesPerosnalWebsite.Pages.SuccessModel>)PageContext?.ViewData;
        public RazorPagesPerosnalWebsite.Pages.SuccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
