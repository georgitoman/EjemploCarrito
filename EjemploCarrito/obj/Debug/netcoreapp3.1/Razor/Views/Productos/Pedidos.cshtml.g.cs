#pragma checksum "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "257b5cd6d1324b9c92200ce92836eb0df4a9e2bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Pedidos), @"mvc.1.0.view", @"/Views/Productos/Pedidos.cshtml")]
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
#nullable restore
#line 1 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\_ViewImports.cshtml"
using EjemploCarrito;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\_ViewImports.cshtml"
using EjemploCarrito.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"257b5cd6d1324b9c92200ce92836eb0df4a9e2bb", @"/Views/Productos/Pedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88581ca6793ad2f60a6291fbc9fc6c444528a422", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Pedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EjemploCarrito.Models.Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
  
    ViewData["Title"] = "Pedidos";
    int precio = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pedidos</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n");
#nullable restore
#line 29 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
                  
                    precio += item.Precio;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><b>Precio total:</b></td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\georg\Desktop\EjemploCarrito\EjemploCarrito\Views\Productos\Pedidos.cshtml"
           Write(precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EjemploCarrito.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
