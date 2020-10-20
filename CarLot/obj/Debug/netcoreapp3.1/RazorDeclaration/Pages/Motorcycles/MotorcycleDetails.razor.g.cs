#pragma checksum "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Motorcycles\MotorcycleDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d46041728f98ebfba3a0f207d2c89c4e05083e72"
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
#nullable restore
#line 3 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Motorcycles\MotorcycleDetails.razor"
using CarLot.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Motorcycles\MotorcycleDetails.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/motorcycle/details/{motorcycleId}")]
    public partial class MotorcycleDetails : OwningComponentBase<MotorcycleService>, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 370 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Motorcycles\MotorcycleDetails.razor"
 
    public Motorcycle motorcycles { get; set; } = new Motorcycle();
    public byte[] ImgUploaded { get; set; }
    public List<Motorcycle> listMotorcycles { get; set; } = new List<Motorcycle>();
    public CarLot.Models.Motorcycle Model = new CarLot.Models.Motorcycle();
    protected bool[] boolItems =
           {
                true,
                false
            };

    public int motorcycleToDelete;

    [Parameter]
    public string motorcycleId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        motorcycles = await motorcycleService.GetMotorcycleByIdAsync(int.Parse(motorcycleId));
        listMotorcycles = await motorcycleService.GetMotorcyclesAsync();
    }

    public async Task DetailsClick(MouseEventArgs e)
    {
        motorcycles = await motorcycleService.GetMotorcycleByIdAsync(int.Parse(motorcycleId));
    }

    public async Task OpenDeleteModal(string modalId, int motorcycleItemId)
    {
        motorcycleToDelete = motorcycleItemId;
        await _jsRuntime.InvokeVoidAsync("global.openModal", modalId);
    }

    public async Task SaveMotorcycle(string modalId)
    {
        if (Model.MotorcycleId == 0)
        {

            // id zero represents new item
            Model.CreatedDate = DateTime.Now;
            Model.Image = ImgUploaded;
            await motorcycleService.AddMotorcycleAsync(Model);
            listMotorcycles = await motorcycleService.GetMotorcyclesAsync();

        }
        else
        {
            Model.ModifiedDate = DateTime.Now;
            Model.Image = ImgUploaded;
            var motorcycleToUpdate = await motorcycleService.UpdateMotorcycleAsync(Model.MotorcycleId);
            listMotorcycles.Where(_ => _.MotorcycleId == Model.MotorcycleId).FirstOrDefault();
            listMotorcycles.Add(motorcycleToUpdate);
            listMotorcycles = await motorcycleService.GetMotorcyclesAsync();
        }
        await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);

    }

    public async Task ConfirmDelete(string modalId)
    {
        var motorcycleTodelete = listMotorcycles.Where(_ => _.MotorcycleId == motorcycleToDelete).FirstOrDefault();
        await motorcycleService.DeleteMotorcycleAsync(motorcycleToDelete);
        listMotorcycles.Remove(motorcycleTodelete);
        await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
    }

    public async Task OpenModal(string modalId, int itemMotorcycleId)
    {
        if (itemMotorcycleId == 0)
        {
            Model = new CarLot.Models.Motorcycle();

        }
        else
        {
            Model = listMotorcycles.Where(_ => _.MotorcycleId == itemMotorcycleId).FirstOrDefault();
        }

        await _jsRuntime.InvokeVoidAsync("global.openModal", modalId);
    }

    public async Task CloseModal(string modalId)
    {
        await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
    }

    async Task HandleFileSelected(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();

        if (file != null)
        {
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            ImgUploaded = ms.ToArray();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CarLot.Data.MotorcycleService motorcycleService { get; set; }
    }
}
#pragma warning restore 1591
