#pragma checksum "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8269e1f21d409c56aa3d4486f088fccb3218985"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visits_Import), @"mvc.1.0.view", @"/Views/Visits/Import.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Visits/Import.cshtml", typeof(AspNetCore.Views_Visits_Import))]
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
#line 2 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8269e1f21d409c56aa3d4486f088fccb3218985", @"/Views/Visits/Import.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8038c96de865848128906c5aae98036fba8ea009", @"/Views/_ViewImports.cshtml")]
    public class Views_Visits_Import : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CMS.Models.ViewModels.Visits>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Visits", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
  
    ViewData["Title"] = "Import";

#line default
#line hidden
#line 7 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
 if (ViewBag.error == null)
{

#line default
#line hidden
            BeginContext(156, 66, true);
            WriteLiteral("    <p align=\"center\" style=\"font-size:50px;\">Import Success</p>\r\n");
            EndContext();
            BeginContext(1204, 374, true);
            WriteLiteral(@"    <div class=""row d-flex justify-content-center"" >
        <div class=""alert alert-success"" style=""width:40%;padding-right:15px;margin-left:15px;"">
            <h1 class=""alert-heading""style=""margin:5px;"">Success!</h1>
            <div class=""card-body text-secondary d-flex flex-column"">
                <span class=""card-text"" style=""font-size:20px;"">You have added ");
            EndContext();
            BeginContext(1579, 14, false);
#line 39 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                          Write(ViewBag.create);

#line default
#line hidden
            EndContext();
            BeginContext(1593, 110, true);
            WriteLiteral(" data</span>\r\n                <hr />\r\n                <span class=\"card-text\" style=\"font-size:20px;\">updated ");
            EndContext();
            BeginContext(1704, 14, false);
#line 41 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                   Write(ViewBag.update);

#line default
#line hidden
            EndContext();
            BeginContext(1718, 102, true);
            WriteLiteral(" data</span>\r\n                <hr />\r\n                <span class=\"card-text\" style=\"font-size:20px;\">");
            EndContext();
            BeginContext(1821, 14, false);
#line 43 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                           Write(ViewBag.repeat);

#line default
#line hidden
            EndContext();
            BeginContext(1835, 69, true);
            WriteLiteral(" data already exists</span>\r\n            </div>\r\n        </div>\r\n\r\n\r\n");
            EndContext();
#line 52 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
             if (ViewBag.nullrow != null)
            {

#line default
#line hidden
            BeginContext(2191, 188, true);
            WriteLiteral("                <div class=\"alert alert-warning\" style=\"width:40%;margin-left:5%;\">\r\n                    <p style=\"margin:10px;font-size:20px;\" class=\"mb-0\">\r\n                        Have ");
            EndContext();
            BeginContext(2380, 15, false);
#line 56 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                        Write(ViewBag.nullrow);

#line default
#line hidden
            EndContext();
            BeginContext(2395, 167, true);
            WriteLiteral(" rows that have not been added\r\n                        , they are:\r\n                    </p>\r\n                    <p style=\"margin:10px;font-size:15px;color:#ff0000\">");
            EndContext();
            BeginContext(2563, 16, false);
#line 59 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                   Write(ViewBag.position);

#line default
#line hidden
            EndContext();
            BeginContext(2579, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 61 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
            }

#line default
#line hidden
            BeginContext(2624, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 64 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
     if (ViewBag.delete != 0)
    {

#line default
#line hidden
            BeginContext(2680, 210, true);
            WriteLiteral("        <div class=\"row\">\r\n            <!-- column -->\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"card\">\r\n                    <h3 class=\"card-header\">Excel does not contain the following ");
            EndContext();
            BeginContext(2891, 14, false);
#line 70 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                            Write(ViewBag.delete);

#line default
#line hidden
            EndContext();
            BeginContext(2905, 328, true);
            WriteLiteral(@" data can be considered to delete</h3>
                   
                    <div class=""table-responsive"">
                        <table class=""table"" id=""table"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
            EndContext();
            BeginContext(3234, 38, false);
#line 77 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.No));

#line default
#line hidden
            EndContext();
            BeginContext(3272, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(3400, 45, false);
#line 80 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(3445, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(3573, 43, false);
#line 83 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(3616, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(3744, 40, false);
#line 86 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3784, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(3912, 39, false);
#line 89 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Pax));

#line default
#line hidden
            EndContext();
            BeginContext(3951, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(4079, 39, false);
#line 92 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.SIC));

#line default
#line hidden
            EndContext();
            BeginContext(4118, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(4246, 40, false);
#line 95 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Host));

#line default
#line hidden
            EndContext();
            BeginContext(4286, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(4414, 48, false);
#line 98 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.ForeignVisit));

#line default
#line hidden
            EndContext();
            BeginContext(4462, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(4590, 47, false);
#line 101 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                   Write(Html.DisplayNameFor(model => model.dateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(4637, 206, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 107 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(4940, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5073, 37, false);
#line 111 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.No));

#line default
#line hidden
            EndContext();
            BeginContext(5110, 95, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 114 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                              
                                                string startdate = item.StartDate.ToString("dd MMM yyyy,hh:mm", DateTimeFormatInfo.InvariantInfo);
                                            

#line default
#line hidden
            BeginContext(5448, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(5493, 39, false);
#line 117 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => startdate));

#line default
#line hidden
            EndContext();
            BeginContext(5532, 95, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 120 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                              
                                                string enddate = item.EndDate?.ToString("dd MMM yyyy,hh:mm", DateTimeFormatInfo.InvariantInfo);
                                                enddate = (enddate == null) ? "NIL" : enddate;
                                            

#line default
#line hidden
            BeginContext(5963, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(6008, 37, false);
#line 124 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => enddate));

#line default
#line hidden
            EndContext();
            BeginContext(6045, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6185, 39, false);
#line 127 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(6224, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6364, 38, false);
#line 130 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Pax));

#line default
#line hidden
            EndContext();
            BeginContext(6402, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6542, 38, false);
#line 133 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.SIC));

#line default
#line hidden
            EndContext();
            BeginContext(6580, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6720, 39, false);
#line 136 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Host));

#line default
#line hidden
            EndContext();
            BeginContext(6759, 95, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 139 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                              
                                                string foreignVisit = item.ForeignVisit ? "Yes" : "No";
                                            

#line default
#line hidden
            BeginContext(7054, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(7099, 42, false);
#line 142 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => foreignVisit));

#line default
#line hidden
            EndContext();
            BeginContext(7141, 95, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 145 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                              
                                                string dateCreated = item.dateCreated.ToString("dd MMM yyyy,hh:mm", DateTimeFormatInfo.InvariantInfo);
                                            

#line default
#line hidden
            BeginContext(7483, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(7528, 41, false);
#line 148 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                       Write(Html.DisplayFor(modelItem => dateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(7569, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(7708, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d476117b0854ebfb0168967b760c589", async() => {
                BeginContext(7782, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 151 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                   WriteLiteral(item.VisitId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7790, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(7836, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793e593086954562b584e3806bc76d9a", async() => {
                BeginContext(7911, 6, true);
                WriteLiteral("Delete");
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
#line 152 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                     WriteLiteral(item.VisitId);

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
            BeginContext(7921, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 155 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                }

#line default
#line hidden
            BeginContext(8048, 160, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 162 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"

    }

#line default
#line hidden
#line 163 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
     

}
else
{

#line default
#line hidden
            BeginContext(8231, 66, true);
            WriteLiteral("    <p align=\"center\" style=\"font-size:50px;\">Import Failure</p>\r\n");
            EndContext();
#line 169 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
     if (ViewBag.name != null)
    {

#line default
#line hidden
            BeginContext(8336, 98, true);
            WriteLiteral("        <span class=\"d-flex justify-content-center text-danger\" style=\"font-size:25px;\">worksheet:");
            EndContext();
            BeginContext(8435, 12, false);
#line 171 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                                             Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(8447, 97, true);
            WriteLiteral("</span>\r\n        <span class=\"d-flex justify-content-center text-danger\" style=\"font-size:25px;\">");
            EndContext();
            BeginContext(8545, 13, false);
#line 172 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                                   Write(ViewBag.error);

#line default
#line hidden
            EndContext();
            BeginContext(8558, 159, true);
            WriteLiteral("</span>\r\n        <span class=\"d-flex justify-content-center text-warning\" style=\"font-size:25px;\">Note: The data before this worksheet has been added.</span>\r\n");
            EndContext();
#line 174 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(8741, 88, true);
            WriteLiteral("        <span class=\"d-flex justify-content-center text-danger\" style=\"font-size:25px;\">");
            EndContext();
            BeginContext(8830, 13, false);
#line 177 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
                                                                                   Write(ViewBag.error);

#line default
#line hidden
            EndContext();
            BeginContext(8843, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 178 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
    }

#line default
#line hidden
#line 178 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Visits\Import.cshtml"
     
}

#line default
#line hidden
            BeginContext(8862, 41, true);
            WriteLiteral("<p class=\"d-flex justify-content-center\">");
            EndContext();
            BeginContext(8903, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4217281b17047a0bebb7578d8a78776", async() => {
                BeginContext(8978, 12, true);
                WriteLiteral("Back to list");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8994, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CMS.Models.ViewModels.Visits>> Html { get; private set; }
    }
}
#pragma warning restore 1591
