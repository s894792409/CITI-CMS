#pragma checksum "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb19fb42d16d51e0f8f6e2569d411f890cf882ba"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb19fb42d16d51e0f8f6e2569d411f890cf882ba", @"/Views/Shared/_LayoutSite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8038c96de865848128906c5aae98036fba8ea009", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutSite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 120, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html style=\"background:url(/images/bg2.jpg) no-repeat;background-size:cover;z-index:10000000000;\">\r\n");
            EndContext();
            BeginContext(120, 828, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ed40fafb1d4e5085dda9589f316ec4", async() => {
                BeginContext(126, 74, true);
                WriteLiteral("\r\n\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(202, 31, false);
#line 7 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
       Write(((string[])ViewData["Meta"])[0]);

#line default
#line hidden
                EndContext();
                BeginContext(234, 35, true);
                WriteLiteral("</title>\r\n    <meta name=\"keywords\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 269, "\"", 313, 1);
#line 8 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
WriteAttributeValue("", 279, ((string[])ViewData["Meta"])[1], 279, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(314, 33, true);
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 347, "\"", 391, 1);
#line 9 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
WriteAttributeValue("", 357, ((string[])ViewData["Meta"])[2], 357, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(392, 549, true);
                WriteLiteral(@" />
    <link rel=""shortcut icon"" href=""/favicon.ico"">
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
            BeginContext(948, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(950, 620, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db1a2ef3d5b7478ca38d2706f2f1ffa7", async() => {
                BeginContext(956, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(963, 12, false);
#line 25 "C:\Users\L33540.NYPSIT\Desktop\CMSTest2\ASP.NET-Core-CMS-master\CMS\CITI-CMS\CMS\Views\Shared\_LayoutSite.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(975, 588, true);
                WriteLiteral(@"


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
            BeginContext(1570, 11, true);
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
