#pragma checksum "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\BattleLog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e0aa02f65beaf0dc04c09411149a3e750c01301"
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
#line 1 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/battlelog")]
    public partial class BattleLog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BattleLog</h3>\r\n\r\n");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "list-group");
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\BattleLog.razor"
     foreach (var round in BattleService.LastBattle.Log)
	{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\BattleLog.razor"
                    GetClass(round)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\BattleLog.razor"
                                      round

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\BattleLog.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\BattleLog.razor"
       

	string GetClass(string round)
	{
		if (round.Contains("kills"))
			return "list-group-item list-group-item-danger";
		else
			return "list-group-item";
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.IBattleService BattleService { get; set; }
    }
}
#pragma warning restore 1591
