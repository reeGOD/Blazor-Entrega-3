#pragma checksum "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da5cb04638e0a0961f9922ec10f1afdd9ab119f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_mysql.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using blazor_mysql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\_Imports.razor"
using blazor_mysql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\Pages\FetchData.razor"
using blazor_mysql.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "H:\GitHub\Blazor-Entrega-3\blazor-mysql\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
