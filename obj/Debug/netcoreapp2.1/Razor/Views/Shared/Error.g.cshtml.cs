#pragma checksum "C:\Projects\DCap\App\Brandix.DCAP.WebUI - BarcodeScan\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "304b4e364b8048f920acf2f3bc1a56ce395c322b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - BarcodeScan\Views\_ViewImports.cshtml"
using Brandix.DCAP.WebUI;

#line default
#line hidden
#line 2 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - BarcodeScan\Views\_ViewImports.cshtml"
using Brandix.DCAP.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"304b4e364b8048f920acf2f3bc1a56ce395c322b", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ac14fb493c2990ba4a5667bd32d8705427078c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exception>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - BarcodeScan\Views\Shared\Error.cshtml"
  
    ViewBag.Title = "Oops!";

#line default
#line hidden
            BeginContext(57, 241, true);
            WriteLiteral("<h1 class=\"text-danger\">Oops! an error occurs</h1>\r\n<img src=\"/images/error-graphic.png\" alt=\"Paris\" class=\"erroPageImage\"> \r\n<h2 class=\"text-danger\" style=\"text-align: center;\">An error occurred while processing your request.</h2>        \r\n");
            EndContext();
#line 9 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - BarcodeScan\Views\Shared\Error.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
            BeginContext(327, 37, false);
#line 11 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - BarcodeScan\Views\Shared\Error.cshtml"
Write(Html.ValueFor(model => model.Message));

#line default
#line hidden
            EndContext();
#line 11 "C:\Projects\DCap\App\Brandix.DCAP.WebUI - BarcodeScan\Views\Shared\Error.cshtml"
                                          
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exception> Html { get; private set; }
    }
}
#pragma warning restore 1591
