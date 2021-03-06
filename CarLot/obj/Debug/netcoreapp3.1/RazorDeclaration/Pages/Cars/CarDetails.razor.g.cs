#pragma checksum "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Cars\CarDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6ab96d320155a73508ed0324f042b7481ff49a3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CarLot.Pages.Cars
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
#line 2 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Cars\CarDetails.razor"
using CarLot.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Cars\CarDetails.razor"
using CarLot.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Cars\CarDetails.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/car/details/{carId}")]
    public partial class CarDetails : OwningComponentBase<CarService>, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 380 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Cars\CarDetails.razor"
 
    public Car cars { get; set; } = new Car();
    public byte[] ImgUploaded { get; set; }
    public List<Car> listCars { get; set; } = new List<Car>();
    public CarLot.Models.Car Model = new CarLot.Models.Car();
    protected bool[] boolItems =
           {
                true,
                false
            };

    public int carToDelete;

    [Parameter]
    public string carId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        cars = await carService.GetCarByIdAsync(int.Parse(carId));
        listCars = await carService.GetCarsAsync();
    }

    public async Task DetailsClick(MouseEventArgs e)
    {
        cars = await carService.GetCarByIdAsync(int.Parse(carId));
    }

    public async Task OpenDeleteModal(string modalId, int carItemId)
    {
        carToDelete = carItemId;
        await _jsRuntime.InvokeVoidAsync("global.openModal", modalId);
    }

    public async Task SaveCar(string modalId)
    {
        if (Model.CarId == 0)
        {

            // id zero represents new item
            Model.CreatedDate = DateTime.Now;
            Model.Image = ImgUploaded;
            await carService.AddCarAsync(Model);
            listCars = await carService.GetCarsAsync();

        }
        else
        {
            Model.ModifiedDate = DateTime.Now;
            Model.Image = ImgUploaded;
            var carToUpdate = await carService.UpdateCarAsync(Model.CarId);
            listCars.Where(_ => _.CarId == Model.CarId).FirstOrDefault();
            listCars.Add(carToUpdate);
            listCars = await carService.GetCarsAsync();
        }
        await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);

    }

    public async Task ConfirmDelete(string modalId)
    {
        var carTodelete = listCars.Where(_ => _.CarId == carToDelete).FirstOrDefault();
        await carService.DeleteCarAsync(carToDelete);
        listCars.Remove(carTodelete);
        await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
    }

    public async Task OpenModal(string modalId, int itemCarId)
    {
        if (itemCarId == 0)
        {
            Model = new CarLot.Models.Car();

        }
        else
        {
            Model = listCars.Where(_ => _.CarId == itemCarId).FirstOrDefault();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CarLot.Data.CarService carService { get; set; }
    }
}
#pragma warning restore 1591
