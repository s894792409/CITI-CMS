#pragma checksum "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8a2bd71b303e4794d08741dcfaabdb05cdfc510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Themes_Index), @"mvc.1.0.view", @"/Views/Themes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Themes/Index.cshtml", typeof(AspNetCore.Views_Themes_Index))]
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
#line 1 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
#line 3 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\_ViewImports.cshtml"
using CMS.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\_ViewImports.cshtml"
using CMS.Infrastructure;

#line default
#line hidden
#line 5 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\_ViewImports.cshtml"
using CMS.Components;

#line default
#line hidden
#line 6 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8a2bd71b303e4794d08741dcfaabdb05cdfc510", @"/Views/Themes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8038c96de865848128906c5aae98036fba8ea009", @"/Views/_ViewImports.cshtml")]
    public class Views_Themes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CMS.Models.ViewModels.Theme>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
  
    ViewData["Title"] = "Index theme";

#line default
#line hidden
            BeginContext(126, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(155, 15, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae7af35876ba4020a2addb437377c707", async() => {
                BeginContext(161, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(170, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(172, 7128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a58d92e58784814a92e2c4a7b23f699", async() => {
                BeginContext(178, 96, true);
                WriteLiteral("\r\n    <p align=\"center\" style=\"font-size:50px;\">All themes</p>\r\n    <p align=\"center\">\r\n        ");
                EndContext();
                BeginContext(274, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e8a6d2ca4743be900c9e35ad845710", async() => {
                    BeginContext(318, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(332, 12, true);
                WriteLiteral("\r\n    </p>\r\n");
                EndContext();
                BeginContext(1669, 356, true);
                WriteLiteral(@"    <div class=""row"">
        <!-- column -->
        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""table-responsive"">
                    <table class=""table"" id=""table"">
                        <thead>
                            <tr>
                                <th>
                                    ");
                EndContext();
                BeginContext(2026, 45, false);
#line 51 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.themeName));

#line default
#line hidden
                EndContext();
                BeginContext(2071, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(2187, 51, false);
#line 54 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.backgroundColor));

#line default
#line hidden
                EndContext();
                BeginContext(2238, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(2354, 45, false);
#line 57 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.fontStyle));

#line default
#line hidden
                EndContext();
                BeginContext(2399, 186, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
                EndContext();
#line 63 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                              
                                var rowsum = 0;
                            

#line default
#line hidden
                BeginContext(2697, 28, true);
                WriteLiteral("                            ");
                EndContext();
#line 66 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                             foreach (var item in Model)
                            {
                                rowsum++;

#line default
#line hidden
                BeginContext(2829, 146, true);
                WriteLiteral("                                <tr>\r\n                                    <td style=\"line-height:40px;\">\r\n                                        ");
                EndContext();
                BeginContext(2976, 44, false);
#line 71 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.themeName));

#line default
#line hidden
                EndContext();
                BeginContext(3020, 153, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"line-height:40px;\">\r\n                                        ");
                EndContext();
                BeginContext(3174, 50, false);
#line 74 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.backgroundColor));

#line default
#line hidden
                EndContext();
                BeginContext(3224, 153, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"line-height:40px;\">\r\n                                        ");
                EndContext();
                BeginContext(3378, 44, false);
#line 77 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.fontStyle));

#line default
#line hidden
                EndContext();
                BeginContext(3422, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3549, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d94c84a85a44a329ecdb91c6aef4376", async() => {
                    BeginContext(3623, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 80 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                                                               WriteLiteral(item.themeId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3631, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3765, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(3805, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "579b8d5e74424eacb268e1dbca9e0325", async() => {
                    BeginContext(3880, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 82 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                                                                 WriteLiteral(item.themeId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3890, 84, true);
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 85 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(4005, 351, true);
                WriteLiteral(@"                        </tbody>
                    </table>
                    <nav aria-label=""Page navigation example"" class=""d-flex justify-content-center"">
                        <ul class=""pagination"" id=""pagebutton"">
                            <li class=""page-item""><a class=""page-link"" href=""#"" onclick=""Previous()"">Previous</a></li>
");
                EndContext();
#line 91 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                              
                                int tabsum = (rowsum % ViewBag.rows == 0) ? rowsum / ViewBag.rows : rowsum / ViewBag.rows + 1;
                                if (tabsum == 0)
                                {
                                    tabsum = 1;
                                }
                            

#line default
#line hidden
                BeginContext(4716, 28, true);
                WriteLiteral("                            ");
                EndContext();
#line 98 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                             for (var s = 1; s <= tabsum; s++)
                            {

#line default
#line hidden
                BeginContext(4811, 83, true);
                WriteLiteral("                                <li class=\"page-item\"><a class=\"page-link\" href=\"#\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4894, "\"", 4918, 3);
                WriteAttributeValue("", 4904, "PageSwitch(", 4904, 11, true);
#line 100 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
WriteAttributeValue("", 4915, s, 4915, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 4917, ")", 4917, 1, true);
                EndWriteAttribute();
                BeginContext(4919, 11, true);
                WriteLiteral(" name=\"ym\">");
                EndContext();
                BeginContext(4931, 1, false);
#line 100 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                                                                                                                  Write(s);

#line default
#line hidden
                EndContext();
                BeginContext(4932, 11, true);
                WriteLiteral("</a></li>\r\n");
                EndContext();
#line 101 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"

                            }

#line default
#line hidden
                BeginContext(4976, 522, true);
                WriteLiteral(@"                            <li class=""page-item""><a class=""page-link"" href=""#"" onclick=""Next()"">Next</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <script type=""text/javascript"">
        var table;
        var rowSum;
        var pageSum;
        var page;

        window.onload = function () {
            table = document.getElementById(""table"");
            rowSum = table.rows.length;
            showrows = ");
                EndContext();
                BeginContext(5499, 12, false);
#line 119 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Themes\Index.cshtml"
                  Write(ViewBag.rows);

#line default
#line hidden
                EndContext();
                BeginContext(5511, 1782, true);
                WriteLiteral(@";    //显示的行数
            pageSum = Math.ceil(rowSum / showrows);
            page = 1;

            PageSwitch(page);
        }
        function PageSwitch(newpage) {

            if (newpage > 0 && newpage <= pageSum) {
                page = newpage;
                for (var e = 1; e <= pageSum; e++) {
                    if (e == newpage) {
                        //var li = document.getElementById(""pagebutton"");
                        //li.classList.add(""active"");
                        document.getElementsByClassName(""page-item"")[e].classList.add(""active"");
                    } else {
                        //var li = document.getElementById(""1"");
                        // li.classList.remove(""active"");
                        document.getElementsByClassName(""page-item"")[e].classList.remove(""active"");
                    }

                }

                for (var i = 1; i < rowSum; i++) {
                    table.rows[i].style.display = ""none"";
                }
      ");
                WriteLiteral(@"          if (newpage == 1) {
                    for (n = newpage * showrows - showrows; n <= newpage * showrows; n++) {
                        table.rows[n].style.display = """";
                    }
                } else {
                    for (var n = newpage * showrows - showrows + 1; n <= newpage * showrows; n++) {
                        table.rows[n].style.display = """";
                    }
                }
            }
        }
        function Previous() {
            if (page > 1 && page <= pageSum) {
                PageSwitch(--page);
            }

        }
        function Next() {
            if (page > 0 && page < pageSum) {
                PageSwitch(++page);
            }

        }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7300, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CMS.Models.ViewModels.Theme>> Html { get; private set; }
    }
}
#pragma warning restore 1591
