#pragma checksum "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfa675d0519bff25cc825ff0f64e6ec00275e412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutSite), @"mvc.1.0.view", @"/Views/Shared/_LayoutSite.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutSite.cshtml", typeof(AspNetCore.Views_Shared__LayoutSite))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa675d0519bff25cc825ff0f64e6ec00275e412", @"/Views/Shared/_LayoutSite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8038c96de865848128906c5aae98036fba8ea009", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutSite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fh5co-header-subscribe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 1023, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14ae25e3e6454f8b80b3f529b9213900", async() => {
                BeginContext(33, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(107, 31, false);
#line 6 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
       Write(((string[])ViewData["Meta"])[0]);

#line default
#line hidden
                EndContext();
                BeginContext(139, 39, true);
                WriteLiteral("</title>\r\n        <meta name=\"keywords\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 178, "\"", 222, 1);
#line 7 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
WriteAttributeValue("", 188, ((string[])ViewData["Meta"])[1], 188, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(223, 37, true);
                WriteLiteral(" />\r\n        <meta name=\"description\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 260, "\"", 304, 1);
#line 8 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
WriteAttributeValue("", 270, ((string[])ViewData["Meta"])[2], 270, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(305, 738, true);
                WriteLiteral(@" />
    <link rel=""shortcut icon"" href=""/favicon.ico"">
    <link href=""https://fonts.googleapis.com/css?family=Karla:400,700"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Playfair+Display:400,700"" rel=""stylesheet"">
    <!-- Animate.css -->
    <link rel=""stylesheet"" href=""/site/css/animate.css"">
    <!-- Icomoon Icon Fonts-->
    <link rel=""stylesheet"" href=""/site/css/icomoon.css"">
    <!-- Bootstrap  -->
    <link rel=""stylesheet"" href=""/site/css/bootstrap.css"">
    <!-- Flexslider  -->
    <link rel=""stylesheet"" href=""/site/css/flexslider.css"">
    <link rel=""stylesheet"" href=""/site/css/style.css"">
    <!-- Modernizr JS -->
    <script src=""/site/js/modernizr-2.6.2.min.js""></script>
");
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
            BeginContext(1050, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1052, 6292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dccf57a041042649fdec6e63bd4a537", async() => {
                BeginContext(1058, 354, true);
                WriteLiteral(@"
    <nav id=""fh5co-main-nav"" role=""navigation"">
        <a href=""#"" class=""js-fh5co-nav-toggle fh5co-nav-toggle active""><i></i></a>
        <div class=""js-fullheight fh5co-table"">
            <div class=""fh5co-table-cell js-fullheight"">
                <h1 class=""text-center""><a class=""fh5co-logo"" href=""index.html"">Menu</a></h1>
                ");
                EndContext();
                BeginContext(1413, 45, false);
#line 30 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
           Write(await Component.InvokeAsync(nameof(SiteMenu)));

#line default
#line hidden
                EndContext();
                BeginContext(1458, 761, true);
                WriteLiteral(@"
                <p class=""fh5co-social-icon"">
                    <a href=""#""><i class=""icon-twitter2""></i></a>
                    <a href=""#""><i class=""icon-facebook2""></i></a>
                    <a href=""#""><i class=""icon-instagram""></i></a>
                    <a href=""#""><i class=""icon-dribbble2""></i></a>
                    <a href=""#""><i class=""icon-youtube""></i></a>
                </p>
            </div>
        </div>
    </nav>

    <div id=""fh5co-page"">
        <header>
            <div class=""container"">
                <div class=""fh5co-navbar-brand"">
                    <div class=""row"">
                        <div class=""col-xs-6"">
                            <h1 class=""text-left"">
                                ");
                EndContext();
                BeginContext(2220, 45, false);
#line 49 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
                           Write(await Component.InvokeAsync(nameof(SiteInfo)));

#line default
#line hidden
                EndContext();
                BeginContext(2265, 841, true);
                WriteLiteral(@"
                            </h1>
                        </div>
                        <div class=""col-xs-6"">
                            <p class=""fh5co-social-icon text-right"">
                                <a href=""#""><i class=""icon-twitter2""></i></a>
                                <a href=""#""><i class=""icon-facebook2""></i></a>
                                <a href=""#""><i class=""icon-instagram""></i></a>
                                <a href=""#""><i class=""icon-dribbble2""></i></a>
                                <a href=""#""><i class=""icon-youtube""></i></a>
                            </p>
                        </div>
                    </div>
                    <a href=""#"" class=""js-fh5co-nav-toggle fh5co-nav-toggle""><i></i></a>
                </div>
            </div>
        </header>

        ");
                EndContext();
                BeginContext(3107, 12, false);
#line 67 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3119, 1858, true);
                WriteLiteral(@"

        <footer>
            <div id=""footer"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <h3 class=""section-title"">About Words</h3>
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics.</p>
                        </div>

                        <div class=""col-md-3 col-md-push-1"">
                            <h3 class=""section-title"">Links</h3>
                            <ul>
                                <li><a href=""#"">Home</a></li>
                                <li><a href=""#"">Work</a></li>
                                <li><a href=""#"">About</a></li>
                                <li><a href=""#"">Blog</a></li>
                                <li><a href=""#"">API</a></li>
                                ");
                WriteLiteral(@"<li><a href=""#"">FAQ / Contact</a></li>
                            </ul>
                        </div>
                        <div class=""col-md-3"">
                            <h3 class=""section-title"">Information</h3>
                            <ul>
                                <li><a href=""#"">Terms &amp; Condition</a></li>
                                <li><a href=""#"">License</a></li>
                                <li><a href=""#"">Privacy &amp; Policy</a></li>
                                <li><a href=""#"">Contact Us</a></li>
                            </ul>
                        </div>
                        <div class=""col-md-3"">
                            <h3 class=""section-title"">Newsletter</h3>
                            <p>Subscribe for our newsletter</p>
                            ");
                EndContext();
                BeginContext(4977, 678, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "defb0440d0204bb9969a2d4fdc11b6ba", async() => {
                    BeginContext(5031, 617, true);
                    WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-12 col-md-offset-0"">
                                        <div class=""form-group"">
                                            <input type=""text"" class=""form-control"" id=""email"" placeholder=""Enter your email"">
                                            <button type=""submit"" class=""btn btn-default""><i class=""icon-paper-plane""></i></button>
                                        </div>
                                    </div>
                                </div>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5655, 1682, true);
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row copy-right"">
                        <div class=""col-md-6 col-md-offset-3 text-center"">
                            <p class=""fh5co-social-icon"">
                                <a href=""#""><i class=""icon-twitter2""></i></a>
                                <a href=""#""><i class=""icon-facebook2""></i></a>
                                <a href=""#""><i class=""icon-instagram""></i></a>
                                <a href=""#""><i class=""icon-dribbble2""></i></a>
                                <a href=""#""><i class=""icon-youtube""></i></a>
                            </p>
                            <p>Copyright 2016 Free Html5 <a href=""#"">Words</a>. All Rights Reserved. <br>Made with <i class=""icon-heart3""></i> by <a href=""http://freehtml5.co/"" target=""_blank"">Freehtml5.co</a> / Demo Images: <a href=""http://blog.gessato.com/"" target=""_blank"">Gessato</a></p>
                        </div>
                    <");
                WriteLiteral(@"/div>
                </div>
            </div>
        </footer>
    </div>
    <!-- jQuery -->
    <script src=""/site/js/jquery.min.js""></script>
    <!-- jQuery Easing -->
    <script src=""/site/js/jquery.easing.1.3.js""></script>
    <!-- Bootstrap -->
    <script src=""/site/js/bootstrap.min.js""></script>
    <!-- Waypoints -->
    <script src=""/site/js/jquery.waypoints.min.js""></script>
    <!-- Counters -->
    <script src=""/site/js/jquery.countTo.js""></script>
    <!-- Flexslider -->
    <script src=""/site/js/jquery.flexslider-min.js""></script>
    <!-- Main JS (Do not remove) -->
    <script src=""/site/js/main.js""></script>
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
            BeginContext(7344, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
