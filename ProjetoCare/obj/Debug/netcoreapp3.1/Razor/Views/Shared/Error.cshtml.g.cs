#pragma checksum "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a5625cc8fb4476f348b0fe9041c550465d8bf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Historico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Categoria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Estoque;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Imagem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Produto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Usuario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Registro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Components.userComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.DefaultValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Components.CartInfoComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Session;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Validations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6a5625cc8fb4476f348b0fe9041c550465d8bf9", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42409d3cfed14c78636ea911632c67dcb20d7a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 12 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 14 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
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