#pragma checksum "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Motorcycles\MotorcycleDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ca6ca2610161596414c31c7f8b88f178cbb08cf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CarLot.Pages.Motorcycles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using CarLot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using CarLot.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using CarLot.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Motorcycles\MotorcycleDetails.razor"
using CarLot.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/motorcycle/details/{motorcycleId}")]
    public partial class MotorcycleDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Motorcycles\MotorcycleDetails.razor"
       
    public Motorcycle Motorcycle { get; set; } = new Motorcycle();
    [Parameter]
    public string motorcycleId { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Motorcycle = await motorcycleService.GetMotorcycleByIdAsync(int.Parse(motorcycleId));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CarLot.Data.MotorcycleService motorcycleService { get; set; }
    }
}
#pragma warning restore 1591
