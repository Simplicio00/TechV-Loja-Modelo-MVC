#pragma checksum "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c088e73dd57e34d08c78757b68ec08e5d1c5e486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Produto), @"mvc.1.0.view", @"/Views/Home/Produto.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Historico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Categoria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Estoque;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Imagem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Produto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Usuario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using Classes.Registro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Components.userComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.DefaultValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Components.CartInfoComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Session;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\_ViewImports.cshtml"
using ProjetoCare.Utils.Validations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c088e73dd57e34d08c78757b68ec08e5d1c5e486", @"/Views/Home/Produto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42409d3cfed14c78636ea911632c67dcb20d7a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Produto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tm-blue-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addtocart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tm-btn tm-btn-gray tm-margin-r-20 tm-margin-b-s"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:60px;display:flex;justify-content:center;align-items:center; color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
  
	ViewData["Title"] = "Produto";
	UserInfoViewModel user = usr.GetUser();
	var list = sp.Search().ToList();
	int total = 0;
	foreach (var item in list)
	{
		total += item.QuantidadeCarrinho;
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
 if (user != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c088e73dd57e34d08c78757b68ec08e5d1c5e4868732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 21 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(CartInfoComponent);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("Param-Valor", "Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper", "Parameters"));
            }
#nullable restore
#line 21 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Valor"] = total;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("Param-Valor", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Valor"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Nome"] = user.Nome;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("Param-Nome", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Nome"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Static;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c088e73dd57e34d08c78757b68ec08e5d1c5e48612201", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 25 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(CartInfoComponent);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("Param-Valor", "Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper", "Parameters"));
            }
#nullable restore
#line 25 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Valor"] = total;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("Param-Valor", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.Parameters["Valor"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Static;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"row tm-item-preview\">\r\n\t<div class=\"col-md-6 col-sm-12 mb-md-0 mb-5\">\r\n");
#nullable restore
#line 30 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
         if (Model.Imagens.Count > 0)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 664, "\"", 734, 2);
            WriteAttributeValue("", 670, "https://localhost:5001/pdts/", 670, 28, true);
#nullable restore
#line 32 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
WriteAttributeValue("", 698, Model.Imagens.First().ImagemCaminho, 698, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid tm-img-center-sm\">\r\n");
#nullable restore
#line 33 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<img src=\"https://localhost:5001/pdts/padraopd.png\" alt=\"Image\" class=\"img-fluid tm-img-center-sm\">\r\n");
#nullable restore
#line 37 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n\t<div class=\"col-md-6 col-sm-12\">\r\n\t\t<h2 class=\"tm-blue-text tm-margin-b-p\">");
#nullable restore
#line 40 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
                                          Write(Model.NomeProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t<p class=\"tm-margin-b-p\">");
#nullable restore
#line 41 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
                            Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t<p class=\"tm-blue-text tm-margin-b-s\">Categoria: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c088e73dd57e34d08c78757b68ec08e5d1c5e48617316", async() => {
#nullable restore
#line 42 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
                                                                                                                                                                Write(Model.IdCategoriaNavigation.NomeCategoria);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoria", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
                                                                                        WriteLiteral(Model.IdCategoriaNavigation.NomeCategoria);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoria"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoria", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoria"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\t\t<p class=\"tm-black-text tm-margin-b-s\">Preço: ");
#nullable restore
#line 43 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
                                                 Write(Model.Preco.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
         if (list.FirstOrDefault(a => a.IdProduto == Model.IdProduto) != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<p class=\"text-success\" >Você já adicionou este produto á sua cesta</p>\r\n");
#nullable restore
#line 48 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c088e73dd57e34d08c78757b68ec08e5d1c5e48620956", async() => {
                WriteLiteral("\r\n\t\t\t\tADICIONAR\r\n\t\t\t\t<img src=\"https://localhost:5001/img/cesta.png\" style=\"width: 40px;\" />\r\n\t\t\t");
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
#nullable restore
#line 51 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
                                        WriteLiteral(Model.IdProduto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</section>\r\n\r\n<div class=\"tm-gallery no-pad-b\">\r\n\t<div class=\"row\">\r\n");
#nullable restore
#line 62 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
         if (Model.Imagens.Count > 0)
		{
			foreach (var item in Model.Imagens.ToList())
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2034, "\"", 2088, 2);
            WriteAttributeValue("", 2041, "https://localhost:5001/pdts/", 2041, 28, true);
#nullable restore
#line 66 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
WriteAttributeValue("", 2069, item.ImagemCaminho, 2069, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"col-lg-3 col-md-4 col-sm-6 col-12 tm-gallery-item mb-5\">\r\n\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 2180, "\"", 2233, 2);
            WriteAttributeValue("", 2186, "https://localhost:5001/pdts/", 2186, 28, true);
#nullable restore
#line 67 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
WriteAttributeValue("", 2214, item.ImagemCaminho, 2214, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid tm-img-center\">\r\n\t\t\t\t</a>\r\n");
#nullable restore
#line 69 "C:\Users\Acer\Desktop\Código\TechV-Loja-Modelo-MVC\ProjetoCare\Views\Home\Produto.cshtml"
			}
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</div>     ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ShoppingCart sp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserSession usr { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
