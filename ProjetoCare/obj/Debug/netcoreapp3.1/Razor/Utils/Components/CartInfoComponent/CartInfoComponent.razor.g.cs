#pragma checksum "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\CartInfoComponent\CartInfoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d33046840d82b0e1b353d06855cb7419d969e6a6"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjetoCare.Utils.Components.CartInfoComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
    public partial class CartInfoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "cartinfo");
            __builder.AddAttribute(2, "style", "display: flex; justify-content:center;align-items:center;align-content:center; padding:5px;");
            __builder.AddMarkupContent(3, "\r\n\t\t");
            __builder.AddMarkupContent(4, @"<a href=""https://localhost:5001/cesta"" style=""margin-left: 10px; height:30px; font-size:11px;width:150px;display:flex;align-items:center;justify-content:center;"" class=""tm-btn tm-btn-blue"">Minha cesta</a>
		<img src=""https://localhost:5001/img/cesta.png"" style=""width: 50px; cursor:pointer;"">
		 ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, " Produtos adicionados:  ");
            __builder.AddContent(7, 
#nullable restore
#line 4 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\CartInfoComponent\CartInfoComponent.razor"
                                     Valor

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, " \r\n\t\r\n\r\n\t");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "width:50%;display:flex; padding:10px;align-items:center; justify-content:flex-end; font-size:15px;");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 8 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\CartInfoComponent\CartInfoComponent.razor"
         if (Nome != null)
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "\t\t\t");
            __builder.OpenElement(14, "p");
            __builder.AddMarkupContent(15, " Olá ");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\CartInfoComponent\CartInfoComponent.razor"
                     Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.CloseElement();
            __builder.AddContent(18, " ");
            __builder.AddMarkupContent(19, "<a id=\"logoutbtn\" style=\"margin-left: 10px;cursor:pointer;\">a<i class=\"fas fa-sign-out-alt\"></i></a>\r\n");
#nullable restore
#line 11 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\CartInfoComponent\CartInfoComponent.razor"
		}
		else
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "\t\t\t");
            __builder.AddMarkupContent(21, "<p>Faça login para prosseguir com a sua compra</p> ");
            __builder.AddMarkupContent(22, "<a href=\"#\" style=\"margin-left: 10px;\"><i style=\"font-size: 30px;\" class=\"fas fa-door-open\"></i></a>\r\n");
#nullable restore
#line 15 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\CartInfoComponent\CartInfoComponent.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n<hr style=\"width: 100%; color:gray; height:30px;\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\CartInfoComponent\CartInfoComponent.razor"
       
	[Parameter]
	public int Valor { get; set; }

	[Parameter]
	public string Nome { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
