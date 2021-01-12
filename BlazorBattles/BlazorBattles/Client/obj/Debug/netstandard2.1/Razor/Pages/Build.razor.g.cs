#pragma checksum "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "443a5d303ef1c48d9324bc99a8af5c5fa0f6fb86"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/build")]
    public partial class Build : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Build</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", "form-control");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor"
                   selectedUnitId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedUnitId = __value, selectedUnitId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor"
         foreach (var unit in UnitService.Units)
		{ 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor"
                            unit.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, 
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor"
                                      unit.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " // ");
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor"
                                                     unit.BananaCost

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " Bananas");
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor"
                  BuildUnit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddContent(17, "Build");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Build.razor"
       
	int selectedUnitId = 1;

	public void BuildUnit()
	{
		BlazorBattles.Shared.Unit selectedUnit =
			UnitService.Units.FirstOrDefault(unit => unit.Id == selectedUnitId);
		BananaService.EatBananas(selectedUnit.BananaCost);
		UnitService.AddUnit(selectedUnitId);
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.IUnitService UnitService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.IBananaService BananaService { get; set; }
    }
}
#pragma warning restore 1591
