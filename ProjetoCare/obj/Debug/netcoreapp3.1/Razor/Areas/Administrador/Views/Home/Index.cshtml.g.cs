#pragma checksum "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae28e822af18c19919b139cb6fd1869cfdd0c726"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrador_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Administrador/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using ProjetoCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Validations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.DefaultValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using Classes.Historico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using Classes.Categoria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using Classes.Estoque;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using Classes.Imagem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using Classes.Produto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using Classes.Usuario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Session;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae28e822af18c19919b139cb6fd1869cfdd0c726", @"/Areas/Administrador/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6afb307a8b6d1d060544b8f13cd6cc8b11dad46", @"/Areas/Administrador/Views/_ViewImports.cshtml")]
    public class Areas_Administrador_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HistoricoCompra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid adm-home\">\r\n\t\r\n");
#nullable restore
#line 8 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\Home\Index.cshtml"
     foreach (var item in Model.ToList())
	{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"card text-white bg-success mb-3\" style=\"max-width: 18rem; z-index:100;background-color:white;\">\r\n\t\t\t\t<div class=\"card-header\">");
#nullable restore
#line 12 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\Home\Index.cshtml"
                                    Write(item.DataEmissao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae28e822af18c19919b139cb6fd1869cfdd0c7267604", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<h5 class=\"card-title\" style=\"color: white;\" >");
#nullable restore
#line 15 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\Home\Index.cshtml"
                                                             Write(item.Codigo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\Home\Index.cshtml"
                                                  WriteLiteral(item.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t<p class=\"card-text\"> <b>REQUISITANTE:</b> ");
#nullable restore
#line 18 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\Home\Index.cshtml"
                                                          Write(item.IdUsuarioNavigation.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 21 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Areas\Administrador\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HistoricoCompra>> Html { get; private set; }
    }
}
#pragma warning restore 1591