#pragma checksum "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6131280957b2200fc5c413914628e07b44346f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Index.cshtml", typeof(AspNetCore.Views_Projects_Index))]
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
#line 2 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6131280957b2200fc5c413914628e07b44346f", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8038c96de865848128906c5aae98036fba8ea009", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CMS.Models.ViewModels.Projects>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QueryView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
  
    ViewData["Title"] = "All project";

#line default
#line hidden
            BeginContext(129, 86, true);
            WriteLiteral("\r\n<p align=\"center\" style=\"font-size:50px;\">All projects</p>\r\n<p align=\"center\">\r\n    ");
            EndContext();
            BeginContext(215, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1812c6b4752d4f6ba269896552aa38dc", async() => {
                BeginContext(259, 10, true);
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
            BeginContext(273, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(279, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab400d0a45804ed387c1675343d32dd0", async() => {
                BeginContext(326, 13, true);
                WriteLiteral("Query project");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(343, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(1580, 316, true);
            WriteLiteral(@"<div class=""row"">
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
            BeginContext(1897, 47, false);
#line 46 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.projectName));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2048, 48, false);
#line 49 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.projectState));

#line default
#line hidden
            EndContext();
            BeginContext(2096, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2200, 48, false);
#line 52 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.noOfStudents));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 58 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                          
                            CMSContext context = new CMSContext();
                            var list = context.Student.ToList();
                        

#line default
#line hidden
            BeginContext(2603, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 62 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                          
                            var rowsum = 0;
                        

#line default
#line hidden
            BeginContext(2703, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 65 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                         foreach (var item in Model)
                        {
                            rowsum++;

#line default
#line hidden
            BeginContext(2823, 134, true);
            WriteLiteral("                            <tr>\r\n                                <td style=\"line-height:40px;\">\r\n                                    ");
            EndContext();
            BeginContext(2958, 46, false);
#line 70 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.projectName));

#line default
#line hidden
            EndContext();
            BeginContext(3004, 141, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"line-height:40px;\">\r\n                                    ");
            EndContext();
            BeginContext(3146, 47, false);
#line 73 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.projectState));

#line default
#line hidden
            EndContext();
            BeginContext(3193, 105, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"line-height:40px;\">\r\n");
            EndContext();
#line 76 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                                      
                                        int i = 0;
                                        foreach (Student student in list)
                                        {
                                            if (student.projectId == item.projectId)
                                            {
                                                i++;
                                            }
                                        }
                                        context.Update(item);
                                        await context.SaveChangesAsync();
                                    

#line default
#line hidden
            BeginContext(3962, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3999, 31, false);
#line 88 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => i));

#line default
#line hidden
            EndContext();
            BeginContext(4030, 141, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"line-height:40px;\">\r\n                                    ");
            EndContext();
            BeginContext(4171, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef0bc84d5c5430e92a8156df2fc21a2", async() => {
                BeginContext(4247, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                                                           WriteLiteral(item.projectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4255, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4386, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(4422, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "768fb9bb3f1f40008f28a1e915d8cff9", async() => {
                BeginContext(4499, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                                                             WriteLiteral(item.projectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4509, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 96 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4612, 331, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <nav aria-label=""Page navigation example"" class=""d-flex justify-content-center"">
                    <ul class=""pagination"" id=""pagebutton"">
                        <li class=""page-item""><a class=""page-link"" href=""#"" onclick=""Previous()"">Previous</a></li>
");
            EndContext();
#line 102 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                          
                            int tabsum = (rowsum % ViewBag.rows == 0) ? rowsum / ViewBag.rows : rowsum / ViewBag.rows + 1;
                            if (tabsum == 0)
                            {
                                tabsum = 1;
                            }
                        

#line default
#line hidden
            BeginContext(5275, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 109 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                         for (var s = 1; s <= tabsum; s++)
                        {

#line default
#line hidden
            BeginContext(5362, 79, true);
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5441, "\"", 5465, 3);
            WriteAttributeValue("", 5451, "PageSwitch(", 5451, 11, true);
#line 111 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
WriteAttributeValue("", 5462, s, 5462, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 5464, ")", 5464, 1, true);
            EndWriteAttribute();
            BeginContext(5466, 11, true);
            WriteLiteral(" name=\"ym\">");
            EndContext();
            BeginContext(5478, 1, false);
#line 111 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                                                                                                              Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(5479, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 112 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"

                        }

#line default
#line hidden
            BeginContext(5519, 490, true);
            WriteLiteral(@"                        <li class=""page-item""><a class=""page-link"" href=""#"" onclick=""Next()"">Next</a></li>
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
            BeginContext(6010, 12, false);
#line 130 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Projects\Index.cshtml"
                  Write(ViewBag.rows);

#line default
#line hidden
            EndContext();
            BeginContext(6022, 1776, true);
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
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CMS.Models.ViewModels.Projects>> Html { get; private set; }
    }
}
#pragma warning restore 1591
