#pragma checksum "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b9ddc4998589586638470b0947ef72b59b1da15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Carrinho), @"mvc.1.0.view", @"/Views/Home/Carrinho.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9ddc4998589586638470b0947ef72b59b1da15", @"/Views/Home/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42409d3cfed14c78636ea911632c67dcb20d7a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removeUnit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 10px;height:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addtocart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: darkred;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link-secondary small text-uppercase mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "pagamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: gray;border:gray;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
  
	ViewData["Title"] = "Cesta";


	double total = 0;
    int totalProdutos = 0;

	foreach (var item in Model.ToList())
	{
		total += item.Preco * item.QuantidadeCarrinho;
        totalProdutos += item.QuantidadeCarrinho; 
	}

    var usr = user.GetUser();


#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section>
  <!--Grid row-->
  <div class=""row"">

    <!--Grid column-->
    <div class=""col-lg-8"">

      <!-- Card -->
      <div class=""mb-3"">
        <div class=""pt-4 wish-list"">

          <h5 class=""mb-4"" style=""text-align:center; background-color:black;color:white;"">PRODUTOS</h5>


");
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
           foreach (var item in @Model.ToList())
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mb-4\">\r\n            <div class=\"col-md-5 col-lg-3 col-xl-3\">\r\n              <div class=\"view zoom overlay z-depth-1 rounded mb-3 mb-md-0\">\r\n                <img class=\"img-fluid w-100\"");
            BeginWriteAttribute("src", "\r\n                  src=\"", 950, "\"", 1015, 2);
            WriteAttributeValue("", 975, "https://localhost:5001/pdts/", 975, 28, true);
#nullable restore
#line 44 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
WriteAttributeValue("", 1003, item.Imagem, 1003, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Sample\">\r\n              </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"col-md-7 col-lg-9 col-xl-9\">\r\n              <div>\r\n                <div class=\"d-flex justify-content-between\">\r\n                  <div>\r\n                    <h5>");
#nullable restore
#line 53 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                   Write(item.NomeProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"mb-3 text-muted text-uppercase small\">");
#nullable restore
#line 54 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                                                               Write(item.Preco.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" (unidade)</p>
                  </div>
                  <div>
                    <div style=""display:flex;padding:10px;align-items:center; justify-content:center; height:120px; flex-flow:column;"" class=""def-number-input number-input safari_only mb-0 w-100"">
                      <div>

                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9ddc4998589586638470b0947ef72b59b1da1513237", async() => {
                WriteLiteral("Diminuir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                                                   WriteLiteral(item.IdProduto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                      \r\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9ddc4998589586638470b0947ef72b59b1da1515552", async() => {
                WriteLiteral("Acrescentar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                                                                                                     WriteLiteral(item.IdProduto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                      </div>\r\n                      <h6>Quantidade: ");
#nullable restore
#line 64 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                                 Write(item.QuantidadeCarrinho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n\r\n\r\n                <div class=\"d-flex justify-content-between align-items-center\">\r\n                  <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9ddc4998589586638470b0947ef72b59b1da1518533", async() => {
                WriteLiteral("<i\r\n                        class=\"fas fa-trash-alt mr-1\"></i> Remover ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                                                                     WriteLiteral(item.IdProduto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n                  <p class=\"mb-0\"><span><strong id=\"summary\">");
#nullable restore
#line 76 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                                                         Write((item.Preco * item.QuantidadeCarrinho).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span></p class=\"mb-0\">\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <hr class=\"mb-4\">\r\n");
#nullable restore
#line 82 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
              
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          \r\n\r\n");
            WriteLiteral("\r\n\r\n          \r\n\r\n\r\n\r\n        </div>\r\n      </div>\r\n      <!-- Card -->\r\n\r\n      <!-- Card -->\r\n      <div class=\"mb-3\">\r\n        <div class=\"pt-4\">\r\n\r\n");
            WriteLiteral(@"        </div>
      </div>
      <!-- Card -->

      <!-- Card -->
      <div class=""mb-3"">
        
        <div class=""pt-4"">


          <h5 class=""mb-4"">Nós aceitamos</h5>

          <img class=""mr-2"" width=""45px""
            src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/visa.svg""
            alt=""Visa"">
          <img class=""mr-2"" width=""45px""
            src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/amex.svg""
            alt=""American Express"">
          <img class=""mr-2"" width=""45px""
            src=""https://mdbootstrap.com/wp-content/plugins/woocommerce-gateway-stripe/assets/images/mastercard.svg""
            alt=""Mastercard"">
          <img class=""mr-2"" width=""45px""
            src=""https://mdbootstrap.com/wp-content/plugins/woocommerce/includes/gateways/paypal/assets/images/paypal.png""
            alt=""PayPal acceptance mark"">
          
        </div>
      </div>
      <!-- Card -->
");
            WriteLiteral(@"
    </div>
    <!--Grid column-->

    <!--Grid column-->
    <div class=""col-lg-4"">

      <!-- Card -->
      <div class=""mb-3"">
		  <div class=""pt-4"">

			  <ul class=""list-group list-group-flush"">

			  	<li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3"">
			  		<div>
			  			<h5>Total:</h5>
			  		</div>
			  		<span> ");
#nullable restore
#line 148 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                        Write(total.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n\t\t\t  </li>\r\n\r\n");
#nullable restore
#line 151 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
               if (usr != null)
			  {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t  \t<li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3\">\r\n\t\t\t  \t\t<div>\r\n\t\t\t  \t\t\t<h5>Total de produtos:</h5>\r\n\t\t\t  \t\t</div>\r\n\t\t\t  \t\t<span> ");
#nullable restore
#line 157 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
                        Write(totalProdutos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n\t\t\t  </li>\r\n\t\t\t  <li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3\">\r\n\t\t\t  \t<p>Frete (correios) - Altere o seu CEP através das configurações de usuário</p>\r\n\t\t\t  </li>\r\n");
            WriteLiteral("\t\t\t  <li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3\">\r\n\t\t\t  \t<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5154, "\"", 5170, 1);
#nullable restore
#line 165 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
WriteAttributeValue("", 5162, usr.CEP, 5162, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"cepnumb\" />\r\n\t\t\t  </li>\r\n");
            WriteLiteral("\t\t\t  <li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0 mb-3\">\r\n\t\t\t  \t<b>Endereço: </b> <p id=\"endereco\">  </p>\r\n\t\t\t  </li>\r\n");
#nullable restore
#line 171 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"


		  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t  </ul>\r\n\r\n");
#nullable restore
#line 177 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
           if (usr != null)
		  {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t  \t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9ddc4998589586638470b0947ef72b59b1da1526391", async() => {
                WriteLiteral("Prosseguir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 180 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
		  }
		  else
		  {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Faça login para avançar com a sua compra</p>\r\n");
#nullable restore
#line 184 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Views\Home\Carrinho.cshtml"
		  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
		  </div>
      </div>
      <!-- Card -->

      <!-- Card -->
      <div class=""mb-3"">
        <div class=""pt-4"">

          <div class=""collapse"" id=""collapseExample"">
            <div class=""mt-3"">
              <div class=""md-form md-outline mb-0"">
                <input type=""text"" id=""discount-code"" class=""form-control font-weight-light""
                  placeholder=""Enter discount code"">
              </div>
            </div>
          </div>
        </div>
      </div>
      <!-- Card -->

    </div>
    <!--Grid column-->

  </div>
  <!-- Grid row -->

</section>
<!--Section: Block Content-->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserSession user { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
