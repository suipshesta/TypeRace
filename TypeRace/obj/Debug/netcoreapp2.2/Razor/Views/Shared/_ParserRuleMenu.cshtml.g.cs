#pragma checksum "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "481916532d1c08163ca9d20d74dbb420788d71ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ParserRuleMenu), @"mvc.1.0.view", @"/Views/Shared/_ParserRuleMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ParserRuleMenu.cshtml", typeof(AspNetCore.Views_Shared__ParserRuleMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"481916532d1c08163ca9d20d74dbb420788d71ed", @"/Views/Shared/_ParserRuleMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"917e51cc73824be5b4a5f9fcee5c0e87bfe80cda", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ParserRuleMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Parsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rules", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-paId", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 559, true);
            WriteLiteral(@"<style>
    .card {
        background-color: rgba(255,255,255,0.1);
    }
    .list-group-item {
        background-color: rgba(255,255,255,0.2);
        color: #fff;
    }
    .text-tpl {
        color: #29578f;
    }
</style>
<aside class=""sidebar"">
    <h2 class=""d-none"">Main Navigation</h2>
    <div class=""sidebar-sticky bg-dark p-3"" id=""sidebar-sticky"">
        <nav class=""navbar navbar-expand-md navbar-dark bg-dark"">
            <h1 class=""handheld-off"">
                <a class=""navbar-brand d-block text-center mb-5"" href=""#"">
");
            EndContext();
            BeginContext(652, 372, true);
            WriteLiteral(@"                    <h1><strong>Munin</strong></h1>
                    <span class=""brand-icon"">VL</span>
                </a>
            </h1>
            <div class=""card mb-3"" style=""max-height:400px;"">
                <h5 class=""text-light text-center mt-3"">Parsing Rules List</h5>
                <ul class=""list-group list-group-flush"" id=""parserList"">


");
            EndContext();
#line 29 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"
                     foreach (var item in ViewBag.Rules)
                    {   


#line default
#line hidden
            BeginContext(1110, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\'", 1137, "\'", 1230, 4);
            WriteAttributeValue("", 1145, "list-group-item", 1145, 15, true);
            WriteAttributeValue(" ", 1160, "m-2", 1161, 4, true);
            WriteAttributeValue(" ", 1164, "parseRule", 1165, 10, true);
#line 32 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"
WriteAttributeValue(" ", 1174, (ViewBag.CurRuleId==item.ParserId)?"ruleSelected":"", 1175, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1231, 11, true);
            WriteLiteral(" data-pid=\"");
            EndContext();
            BeginContext(1243, 13, false);
#line 32 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"
                                                                                                                               Write(item.ParserId);

#line default
#line hidden
            EndContext();
            BeginContext(1256, 19, true);
            WriteLiteral("\" data-searchJson=\"");
            EndContext();
            BeginContext(1276, 18, false);
#line 32 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"
                                                                                                                                                                Write(item.SearchOptions);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 32, true);
            WriteLiteral("\">\r\n                            ");
            EndContext();
            BeginContext(1326, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "481916532d1c08163ca9d20d74dbb420788d71ed7400", async() => {
                BeginContext(1490, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1525, 15, false);
#line 36 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"
                           Write(item.ParserName);

#line default
#line hidden
                EndContext();
                BeginContext(1540, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ruleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"
                                     WriteLiteral(item.ParserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ruleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ruleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ruleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1574, 224, true);
            WriteLiteral("\r\n\r\n                            <i class=\"fas fa-trash-alt fa-lg float-right p-1 deleteRule\"></i>\r\n                            <i class=\"fas fa-pen-square fa-lg float-right p-1 editRule\"></i>\r\n                        </li>\r\n");
            EndContext();
#line 42 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"

                    }

#line default
#line hidden
            BeginContext(1823, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 44 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"
                     if (ViewBag.CurRuleId == null)
                    {

#line default
#line hidden
            BeginContext(1899, 140, true);
            WriteLiteral("                        <li class=\'list-group-item m-2 parseRule ruleSelected\' data-pid=\"\" data-searchJson=\"\">\r\n                            ");
            EndContext();
            BeginContext(2039, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "481916532d1c08163ca9d20d74dbb420788d71ed11354", async() => {
                BeginContext(2187, 80, true);
                WriteLiteral("\r\n                                New Parsing rule\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-paId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["paId"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2271, 224, true);
            WriteLiteral("\r\n\r\n                            <i class=\"fas fa-trash-alt fa-lg float-right p-1 deleteRule\"></i>\r\n                            <i class=\"fas fa-pen-square fa-lg float-right p-1 editRule\"></i>\r\n                        </li>\r\n");
            EndContext();
#line 56 "C:\Oprojects\MuninV3\Munin\Views\Shared\_ParserRuleMenu.cshtml"
                    }

                    

#line default
#line hidden
            BeginContext(2798, 425, true);
            WriteLiteral(@"
                </ul>
            </div>

            <button type=""button"" class=""btn btn-light btn-block p-4"" id=""addParserRule"">  <i class=""fas fa-plus""></i> &nbsp;Add Parsing Rule</button>
            <button type=""button"" onclick=""location.href = '/Home/Dashboard';"" class=""btn btn-danger btn-block p-4""><i class=""fas fa-sign-out-alt""></i> &nbsp;Exit Parsing Rule</button>
        </nav>
    </div>

</aside>
");
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
