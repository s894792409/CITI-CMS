#pragma checksum "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "361ed41a8400f51f3bfa44533328408d59009dd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presets_Delete), @"mvc.1.0.view", @"/Views/Presets/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Presets/Delete.cshtml", typeof(AspNetCore.Views_Presets_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361ed41a8400f51f3bfa44533328408d59009dd2", @"/Views/Presets/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8038c96de865848128906c5aae98036fba8ea009", @"/Views/_ViewImports.cshtml")]
    public class Views_Presets_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Models.ViewModels.Preset>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
  
    ViewData["Meta"] = new string[3] { "Delete Preset", "MetaKeyword", "MetaDescription" };
    ViewData["Title"] = "Delete Preset";
    ViewData["Controller"] = "Preset";
    CMSContext context = new CMSContext();

#line default
#line hidden
            BeginContext(263, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(290, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e7c048bb754a5aba14eda96efa677f", async() => {
                BeginContext(296, 31, true);
                WriteLiteral("\r\n\r\n    <title>Delete</title>\r\n");
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
            BeginContext(334, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(336, 4136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aae6652d00a4ae08321ce02e09d5b65", async() => {
                BeginContext(342, 637, true);
                WriteLiteral(@"
    <br /><p align=""center"" style=""font-size:50px;"">Delete preset</p>
    <hr />
    <h3>Are you sure you want to delete this?</h3>
    <br /><br />
    <div class=""d-flex justify-content-center"">
        <div class=""card border-dark mb-3"" style=""max-width: 30rem;border:1px solid #808080;min-width:25rem;"">
            <div class=""card-header"" align=""center"">Preset</div>
            <div class="""" style=""width:100%;"" align=""center"">
                <div class=""card-body d-flex justify-content-center"" align=""left"">

                    <dl class=""dl-horizontal"">
                        <dt>
                            ");
                EndContext();
                BeginContext(980, 46, false);
#line 28 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.presetName));

#line default
#line hidden
                EndContext();
                BeginContext(1026, 91, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
                EndContext();
                BeginContext(1118, 42, false);
#line 31 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.presetName));

#line default
#line hidden
                EndContext();
                BeginContext(1160, 164, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Theme Name\r\n                        </dt>\r\n                        <dd>\r\n");
                EndContext();
#line 37 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                              
                                var themename = "";
                                try
                                {

                                    var them = context.Theme.SingleOrDefault(n => n.themeId == Model.themeId);
                                    themename = them.themeName;
                                }
                                catch
                                {
                                    themename = "Not found!";
                                }
                            

#line default
#line hidden
                BeginContext(1898, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1927, 39, false);
#line 50 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                       Write(Html.DisplayFor(modelItem => themename));

#line default
#line hidden
                EndContext();
                BeginContext(1966, 91, true);
                WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
                EndContext();
                BeginContext(2058, 43, false);
#line 53 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.visitId));

#line default
#line hidden
                EndContext();
                BeginContext(2101, 63, true);
                WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n");
                EndContext();
#line 56 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                              

                                Visits visit = context.Visits.SingleOrDefault(s => s.VisitId == Model.visitId);
                                string name = "";
                                if (visit != null)
                                {
                                    name = visit.Name;
                                }
                                else
                                {
                                    name = "Not find this visit!";
                                }

                            

#line default
#line hidden
                BeginContext(2749, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2778, 30, false);
#line 70 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                       Write(Html.DisplayFor(model => name));

#line default
#line hidden
                EndContext();
                BeginContext(2808, 33, true);
                WriteLiteral("\r\n                        </dd>\r\n");
                EndContext();
#line 72 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                          
                            List<Box> boxlist = new List<Box>();
                            List<Card> cards = new List<Card>();
                            try
                            {
                                CMSContext context1 = new CMSContext();
                                boxlist = context1.Box.Where(b => b.presetId == Model.presetId).ToList();

                                foreach (Box box in boxlist)
                                {
                                    var cardlist = context1.Card.Where(b => b.boxId == box.boxId).ToList();
                                    cards.AddRange(cardlist);
                                }

                            }
                            catch { }
                        

#line default
#line hidden
                BeginContext(3650, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 89 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                         if (boxlist.Count > 0)
                        {

#line default
#line hidden
                BeginContext(3726, 191, true);
                WriteLiteral("                            <dt>\r\n                                Boxes and Cards\r\n                            </dt>\r\n                            <dd>\r\n\r\n                                Have ");
                EndContext();
                BeginContext(3918, 13, false);
#line 96 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                                Write(boxlist.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3931, 11, true);
                WriteLiteral(" boxes and ");
                EndContext();
                BeginContext(3943, 11, false);
#line 96 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                                                         Write(cards.Count);

#line default
#line hidden
                EndContext();
                BeginContext(3954, 44, true);
                WriteLiteral(" cards.\r\n                            </dd>\r\n");
                EndContext();
#line 98 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
                        }

#line default
#line hidden
                BeginContext(4025, 67, true);
                WriteLiteral("                    </dl>\r\n                </div>\r\n                ");
                EndContext();
                BeginContext(4092, 323, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b743ad0f5b46411bbebe604579d0981e", async() => {
                    BeginContext(4146, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(4168, 42, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "efd7da30d5314e95b120fbf7fd756b0e", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 102 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Presets\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.presetId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4210, 113, true);
                    WriteLiteral("\r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-outline-danger\" />\r\n                    ");
                    EndContext();
                    BeginContext(4323, 67, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55c427b26fe2499ab9fd8c99a7de6968", async() => {
                        BeginContext(4374, 12, true);
                        WriteLiteral("Back to List");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4390, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4415, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(4472, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Models.ViewModels.Preset> Html { get; private set; }
    }
}
#pragma warning restore 1591
