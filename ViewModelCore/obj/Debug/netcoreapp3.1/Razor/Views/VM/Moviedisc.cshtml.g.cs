#pragma checksum "C:\Core\ViewModelCore\ViewModelCore\Views\VM\Moviedisc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b2c8ab2ff74572dc3ce465ab324214cf9551920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VM_Moviedisc), @"mvc.1.0.view", @"/Views/VM/Moviedisc.cshtml")]
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
#line 1 "C:\Core\ViewModelCore\ViewModelCore\Views\_ViewImports.cshtml"
using ViewModelCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Core\ViewModelCore\ViewModelCore\Views\_ViewImports.cshtml"
using ViewModelCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b2c8ab2ff74572dc3ce465ab324214cf9551920", @"/Views/VM/Moviedisc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b471b8f6772500fdeef5d58b02deae34edb9ff", @"/Views/_ViewImports.cshtml")]
    public class Views_VM_Moviedisc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Core\ViewModelCore\ViewModelCore\Views\VM\Moviedisc.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ViewModelCore.Models.MovieDiscViewModel\r\n");
#nullable restore
#line 2 "C:\Core\ViewModelCore\ViewModelCore\Views\VM\Moviedisc.cshtml"
  
    ViewData["Title"] = "Moviedisc";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MovieInfo</h1>\r\n\r\n");
            WriteLiteral("<h2>DiscInfo</h2>\r\n");
#nullable restore
#line 22 "C:\Core\ViewModelCore\ViewModelCore\Views\VM\Moviedisc.cshtml"
 foreach (var item in Model.discinfo )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n       \r\n        <li>");
#nullable restore
#line 26 "C:\Core\ViewModelCore\ViewModelCore\Views\VM\Moviedisc.cshtml"
       Write(item.DiscName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 27 "C:\Core\ViewModelCore\ViewModelCore\Views\VM\Moviedisc.cshtml"
       Write(item.Mid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n");
#nullable restore
#line 29 "C:\Core\ViewModelCore\ViewModelCore\Views\VM\Moviedisc.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
