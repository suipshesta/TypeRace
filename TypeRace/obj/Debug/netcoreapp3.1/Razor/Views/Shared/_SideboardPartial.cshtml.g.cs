#pragma checksum "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f4c2d8cb4f125a251219429d10a6d60e723534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideboardPartial), @"mvc.1.0.view", @"/Views/Shared/_SideboardPartial.cshtml")]
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
#line 1 "D:\Oprojects\TypeRace\TypeRace\Views\_ViewImports.cshtml"
using TypeRace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Oprojects\TypeRace\TypeRace\Views\_ViewImports.cshtml"
using TypeRace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f4c2d8cb4f125a251219429d10a6d60e723534", @"/Views/Shared/_SideboardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63ecfe17847b9dc5db4eaf6d93b8214dfc5b7ca", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SideboardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<aside class=""aside"" role=""navigation"">
    <h2 class=""sr-only"">Aside</h2>
    <div class=""aside-nav"">
        <div class=""aside-nav-top"">

            <!--brand-->
            <div class=""brand text-center py-3"">
                <a href=""/Dashboard"" class=""brand-item bg-white rounded-circle d-block text-center font-weight-bold mx-auto"" role=""Brand logo"">M</a>
            </div>



            <!--nav top-->
            <nav class=""nav-main"">
                <h3 class=""sr-only"">Main Navigation</h3>
                <ul class=""nav nav-top p-0"">
                    <li");
            BeginWriteAttribute("class", " class=\"", 724, "\"", 786, 2);
            WriteAttributeValue("", 732, "nav-item", 732, 8, true);
#nullable restore
#line 20 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
WriteAttributeValue(" ", 740, ViewBag.nav == "dashboard" ? "active" : "", 741, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"right\" title=\"Dasbhoard\">\r\n                        <a href=\"/Dashboard\" class=\"nav-link\"><i class=\"ri-home-line\"></i><span class=\"nav-label\">Dashboard</span></a>\r\n                    </li>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 1039, "\"", 1099, 2);
            WriteAttributeValue("", 1047, "nav-item", 1047, 8, true);
#nullable restore
#line 23 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
WriteAttributeValue(" ", 1055, ViewBag.nav == "parsers" ? "active" : "", 1056, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"right\" title=\"Parser List\">\r\n                        <a href=\"/Parserslist\" class=\"nav-link\"><i class=\"ri-list-check-2\"></i><span class=\"nav-label\">Parsers</span></a>\r\n                    </li>\r\n");
            WriteLiteral("                </ul>\r\n            </nav>\r\n        </div>\r\n\r\n\r\n        <!--nav bottom-->\r\n        <div class=\"aside-nav-bottom mb-2\">\r\n            <ul class=\"nav p-0\">\r\n");
#nullable restore
#line 35 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
                 if (User.Identity.Name == "mr.void44@gmail.com")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item position-relative status-item"" data-toggle=""tooltip"" data-placement=""right""
                    title=""Status"">
                    <a href=""#"" class=""nav-link status-link"" title=""Status"" data-toggle=""modal""
                       data-target=""#statusModal"">
                        <i class=""ri-code-s-slash-line""></i>
                        <div class=""status-ball"">
                            <span class=""status-ball-item status-ball-1 position-absolute bg-success rounded-circle""></span>
                            <span class=""status-ball-item status-ball-2 position-absolute bg-success rounded-circle""></span>
                        </div>
                        <span class=""nav-label"">Status</span>
                    </a>
                </li>
");
#nullable restore
#line 49 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
                }
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item user-control"">
                        <div class=""nav-link dropup"">
                            <a href=""#"" class=""user-control-item dropdown-toggle dropdown-nocaret rounded-circle p-0 mx-auto"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                ");
#nullable restore
#line 65 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
                           Write(Char.ToUpper(User.Identity.Name[0]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                            <div class=\"dropdown-menu\">\r\n                                <info class=\"dropdown-item d-block mb-3\">\r\n");
            WriteLiteral("                                    <span class=\"text-muted d-block\">");
#nullable restore
#line 70 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
                                                                Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </info>\r\n");
            WriteLiteral("\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53f4c2d8cb4f125a251219429d10a6d60e7235349141", async() => {
                WriteLiteral(@"
                                    <button type=""submit"" class=""dropdown-item"">
                                        <i class=""ri-logout-circle-line mr-1""></i>
                                        Logout
                                    </button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
                                                                                              WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 88 "D:\Oprojects\TypeRace\TypeRace\Views\Shared\_SideboardPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
        </div>

    </div>
</aside>

<!-- Modal status -->
<div class=""modal left modal-sticky-hd fade modal-status"" id=""statusModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""statusModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header d-flex justify-content-between align-items-center border-bottom-0"">
                <h2 class=""h5 modal-title text-light"" id=""statusModal"">Status</h2>
                <div>
                    <button type=""button"" class=""btn btn-light btn-icon rounded-circle"" aria-label=""Refresh""
                            data-toggle=""tooltip"" data-placement=""bottom"" title=""Refresh"">
                        <i class=""ri-restart-line""></i>
                    </button>
                </div>
            </div>

            <div class=""modal-body px-0 pt-0"" id=""statusnotification"" style=""min-height:250px"">

                <!--nodata markup-->
                <div cla");
            WriteLiteral(@"ss=""nodata text-center py-5 px-2 d-none"">
                    <i class=""ri-notification-line h2 mb-3 d-block""></i>
                    <p>You don't have any item</p>
                </div>

                <!--notification list-->
                <ol class=""status-list"" id=""consolelog"">
");
            WriteLiteral("                </ol>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<style>\r\n    .modal-status .slimScrollDiv {\r\n        min-height: 250px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
