<<<<<<< HEAD
#pragma checksum "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb1450996e2d6fe249cae82b9a3e98488a2a6f3"
=======
#pragma checksum "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb1450996e2d6fe249cae82b9a3e98488a2a6f3"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Productos), @"mvc.1.0.view", @"/Views/Producto/Productos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Producto/Productos.cshtml", typeof(AspNetCore.Views_Producto_Productos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb1450996e2d6fe249cae82b9a3e98488a2a6f3", @"/Views/Producto/Productos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24fca49c8f0bf6cf6a935b0c46c3432348e3faf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Productos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tienda.Models.Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(119, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(164, 1, true);
            WriteLiteral("\n");
            EndContext();
<<<<<<< HEAD
#line 7 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml"
=======
#line 7 "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
  
    ViewData["Title"] = "Productos";

#line default
#line hidden
            BeginContext(207, 54, true);
            WriteLiteral("\n\n<div class=\"container\">\n    <div class=\"card-deck\">\n");
            EndContext();
<<<<<<< HEAD
#line 14 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml"
=======
#line 14 "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(308, 119, true);
            WriteLiteral("            <div class=\"card\">\n                <div class=\"view overlay\">\n                    <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 427, "\"", 445, 1);
<<<<<<< HEAD
#line 18 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml"
=======
#line 18 "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
WriteAttributeValue("", 433, item.Imagen, 433, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(446, 260, true);
            WriteLiteral(@" alt=""Imagen""/>
                    <a href=""#!"">
                        <div class=""mask rgba-white-slight""></div>
                    </a>
                </div>
                <div class=""card-body"">
                    <h4 class=""card-title text-center"">");
            EndContext();
            BeginContext(707, 11, false);
<<<<<<< HEAD
#line 24 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml"
=======
#line 24 "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
                                                  Write(item.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(718, 59, true);
            WriteLiteral("</h4>\n                    <p class=\"card-text text-center\">");
            EndContext();
            BeginContext(778, 16, false);
<<<<<<< HEAD
#line 25 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml"
=======
#line 25 "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
                                                Write(item.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(794, 83, true);
            WriteLiteral("</p>\n                    <hr>\n                    <p class=\"card-text text-center\">");
            EndContext();
            BeginContext(878, 10, false);
<<<<<<< HEAD
#line 27 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml"
=======
#line 27 "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
                                                Write(item.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(888, 101, true);
            WriteLiteral("</p>\n                    <hr>\n                    <p class=\"card-text h1 text-center text-success\">$ ");
            EndContext();
            BeginContext(990, 11, false);
<<<<<<< HEAD
#line 29 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml"
=======
#line 29 "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
                                                                  Write(item.Precio);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 47, true);
            WriteLiteral("</p>\n                </div>\n            </div>\n");
            EndContext();
<<<<<<< HEAD
#line 32 "/home/omar/Github/prog-web/Programación Web/Prácticas/Tienda/Tienda/Views/Producto/Productos.cshtml"
=======
#line 32 "/home/omar/Projects/Tienda/Tienda/Views/Producto/Productos.cshtml"
>>>>>>> 9de26e7200d04199efd510dd0f82b43fd64d4f19
        }

#line default
#line hidden
            BeginContext(1058, 19, true);
            WriteLiteral("     </div>\n </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tienda.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
