#pragma checksum "C:\Oprojects\MuninV3\Munin\Views\Shared\_SideMenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "957ba7d5cc531f2df37f748205bd83e0aa861cb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideMenuPartial), @"mvc.1.0.view", @"/Views/Shared/_SideMenuPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SideMenuPartial.cshtml", typeof(AspNetCore.Views_Shared__SideMenuPartial))]
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
#line 1 "C:\Oprojects\MuninV3\Munin\Views\_ViewImports.cshtml"
using Munin;

#line default
#line hidden
#line 2 "C:\Oprojects\MuninV3\Munin\Views\_ViewImports.cshtml"
using Munin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957ba7d5cc531f2df37f748205bd83e0aa861cb7", @"/Views/Shared/_SideMenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"917e51cc73824be5b4a5f9fcee5c0e87bfe80cda", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SideMenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 316, true);
            WriteLiteral(@"
<aside class=""sidebar"">
    <h2 class=""d-none"">Main Navigation</h2>
    <div class=""sidebar-sticky bg-dark"" id=""sidebar-sticky"">
        <nav class=""navbar navbar-expand-md navbar-dark bg-dark"">
            <h1 class=""handheld-off"">
                <a class=""navbar-brand d-block text-center mb-5"" href=""#"">
");
            EndContext();
            BeginContext(409, 551, true);
            WriteLiteral(@"                    <h1><strong>Munin</strong></h1>
                    <span class=""brand-icon"">VL</span>
                </a>
            </h1>

            <div class=""collapse navbar-collapse"" id=""navbarsExample04"">
                <ul class=""navbar-nav flex-column"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/Home/Dashboard"">
                            <i class=""fas fa-tachometer-alt fa-fw mr-3""></i>
                            <span class=""nav-link-label"">Dashboard</span>
");
            EndContext();
            BeginContext(1036, 1097, true);
            WriteLiteral(@"                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Parsers/Create"">
                            <i class=""fab fa-wpforms fa-fw mr-3""></i>
                            <span class=""nav-link-label"">Create Parser</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Parsers/Rules"">
                            <i class=""fab fa-wpforms fa-fw mr-3""></i>
                            <span class=""nav-link-label"">Data Parsing Rule</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Parsers"">
                            <i class=""fab fa-wpforms fa-fw mr-3""></i>
                            <span class=""nav-link-label"">Parsers</span>
                        </a>
                    </li>





          ");
            WriteLiteral("      </ul>\r\n            </div>\r\n        </nav>\r\n    </div>\r\n\r\n</aside>\r\n");
            EndContext();
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
