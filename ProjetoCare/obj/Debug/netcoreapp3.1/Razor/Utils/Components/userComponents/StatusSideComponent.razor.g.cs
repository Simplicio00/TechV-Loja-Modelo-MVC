#pragma checksum "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\userComponents\StatusSideComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ae777c52c430de804f686572b2c17dd7ad4b56b"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjetoCare.Utils.Components.userComponents
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
    public partial class StatusSideComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "leftsidecomponentinfo");
            __builder.AddAttribute(2, "style", "width: 30%;height: 600px;display: flex; flex-direction: column; justify-content: center;align-items: center;");
            __builder.AddMarkupContent(3, "\r\n\r\n\t\t");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "width:90%; height:30%;background-color: white;display: flex;align-items: center;justify-content: center;border: black solid 1px;font-size:12px;");
            __builder.AddMarkupContent(6, "\r\n\t\t\t");
            __builder.OpenElement(7, "p");
            __builder.AddMarkupContent(8, "<b>Nome: </b> ");
            __builder.AddContent(9, 
#nullable restore
#line 4 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\userComponents\StatusSideComponent.razor"
                              Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\t\t");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "style", "width:90%; height:30%;background-color: white;display: flex;align-items: center;justify-content: center;border: black solid 1px;font-size:12px;");
            __builder.AddMarkupContent(15, "\r\n\t\t\t");
            __builder.OpenElement(16, "p");
            __builder.AddMarkupContent(17, "<b>E-Mail: </b> ");
            __builder.AddContent(18, 
#nullable restore
#line 7 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\userComponents\StatusSideComponent.razor"
                                Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t\t");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "width:90%; height:30%;background-color: white;display: flex;align-items: center;justify-content: center;border: black solid 1px;font-size:12px;");
            __builder.AddMarkupContent(24, "\r\n\t\t\t");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "<b> CEP: </b> ");
            __builder.AddContent(27, 
#nullable restore
#line 10 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\userComponents\StatusSideComponent.razor"
                              CEP

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Acer\Desktop\Código\projeto-Care\ProjetoCare\ProjetoCare\Utils\Components\userComponents\StatusSideComponent.razor"
       
    [Parameter]
    public string Nome { get; set; }

    [Parameter]
    public string Email { get; set; }

    [Parameter]
    public string CEP { get; set; }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
