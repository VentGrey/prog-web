<<<<<<< HEAD
#pragma checksum "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Shared/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a5625cc8fb4476f348b0fe9041c550465d8bf9"
=======
#pragma checksum "/home/omar/Projects/Tienda/Tienda/Views/Shared/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a5625cc8fb4476f348b0fe9041c550465d8bf9"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
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
<<<<<<< HEAD
#line 1 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/_ViewImports.cshtml"
=======
#line 1 "/home/omar/Projects/Tienda/Tienda/Views/_ViewImports.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
using Tienda;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/_ViewImports.cshtml"
=======
#line 2 "/home/omar/Projects/Tienda/Tienda/Views/_ViewImports.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
using Tienda.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6a5625cc8fb4476f348b0fe9041c550465d8bf9", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24fca49c8f0bf6cf6a935b0c46c3432348e3faf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
#line 2 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Shared/Error.cshtml"
=======
#line 2 "/home/omar/Projects/Tienda/Tienda/Views/Shared/Error.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 120, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            EndContext();
<<<<<<< HEAD
#line 9 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Shared/Error.cshtml"
=======
#line 9 "/home/omar/Projects/Tienda/Tienda/Views/Shared/Error.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(214, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(267, 15, false);
<<<<<<< HEAD
#line 12 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Shared/Error.cshtml"
=======
#line 12 "/home/omar/Projects/Tienda/Tienda/Views/Shared/Error.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(282, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
<<<<<<< HEAD
#line 14 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Shared/Error.cshtml"
=======
#line 14 "/home/omar/Projects/Tienda/Tienda/Views/Shared/Error.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
}

#line default
#line hidden
            BeginContext(304, 577, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
