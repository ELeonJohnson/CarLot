#pragma checksum "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Buses\Buses.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5ff3959de7e8c6338d5f41a674c24a1851fc9a7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CarLot.Pages.Buses
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
#line 2 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Buses\Buses.razor"
using CarLot.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Buses\Buses.razor"
using CarLot.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Buses\Buses.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/buses")]
    public partial class Buses : OwningComponentBase<BusService>, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 372 "C:\Users\Enoch\Desktop\Projects For Portfolio\CarLot\CarLot\Pages\Buses\Buses.razor"
 
                public CarLot.Models.Bus Model = new CarLot.Models.Bus();
                public List<Bus> buses { get; set; } = new List<Bus>();
                public List<Bus> allBuses { get; set; } = new List<Bus>();
                public byte[] ImgUploaded { get; set; }
                protected bool[] boolItems =
                       {
                true,
                false
            };
                public int busToDelete;



                string busMake = "";
                string busPrice = "";
                string busMileage = "";
                string SearchTerm { get; set; } = "";

                public List<Bus> SearchBusesItems { get; set; } = new List<Bus>();
                public List<Bus> FilteredBuses => SearchBusesItems.Where(i => i.Make.ToLower().Contains(SearchTerm.ToLower())).ToList();



                protected override async Task OnInitializedAsync()
                {
                    buses = await busService.GetBusesAsync();
                    allBuses = await busService.GetBusesAsync();
                    SearchBusesItems = await busService.GetBusesAsync();

                    GetQueryStringValues();
                    NavManager.LocationChanged += HandleLocationChanged;



                    if (busMake != null || busPrice != null || busMileage != null)
                    {
                        buses = await busService.GetFilteredBuses(busMake, busPrice, busMileage);
                        allBuses = await busService.GetFilteredBuses(busMake, busPrice, busMileage);

                    }

                }

                public async Task SearchTextTab(MouseEventArgs e, string busMake, string busPrice,
                    string busMileage)
                {

                    buses = await busService.GetFilteredBuses(busMake, busPrice, busMileage);
                }

                void HandleLocationChanged(object sender, LocationChangedEventArgs e)
                {
                    GetQueryStringValues();
                    StateHasChanged();
                }

                void GetQueryStringValues()
                {
                    NavManager.TryGetQueryString<string>("busMake", out busMake);
                    NavManager.TryGetQueryString<string>("busPrice", out busPrice);
                    NavManager.TryGetQueryString<string>("busMileage", out busMileage);
                }


                public void Dispose()
                {
                    NavManager.LocationChanged -= HandleLocationChanged;
                }

                void ReturnBusesByMake(ChangeEventArgs e)
                {
                    busMake = e.Value.ToString();
                }

                void ReturnBusesByPrice(ChangeEventArgs e)
                {
                    busPrice = e.Value.ToString();
                }

                void ReturnBusesByMileage(ChangeEventArgs e)
                {
                    busMileage = e.Value.ToString();
                }

                void ReturnBusesByFeatures(ChangeEventArgs e)
                {
                    busFeature = e.Value.ToString();
                }


                public async Task FilterClick(MouseEventArgs e, string busMake,
                        string busPrice, string busMileage)
                {
                    buses = await busService.GetFilteredBuses(busMake, busPrice, busMileage);
                    allBuses = await busService.GetFilteredBuses(busMake, busPrice, busMileage);
                }

                public async Task BackToFullList(MouseEventArgs e)
                {

                    SearchTerm = "";
                    allBuses = await busService.GetBusesAsync();
                    buses = await busService.GetBusesAsync();
                }


                public async Task OpenModal(string modalId, int itemBusId)
                {
                    if (itemBusId == 0)
                    {
                        Model = new CarLot.Models.Bus();

                    }
                    else
                    {
                        Model = buses.Where(_ => _.BusId == itemBusId).FirstOrDefault();
                    }

                    await _jsRuntime.InvokeVoidAsync("global.openModal", modalId);
                }

                public async Task CloseModal(string modalId)
                {
                    await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
                }



                public async Task SaveBus(string modalId)
                {
                    if (Model.BusId == 0)
                    {

                        // id zero represents new item
                        Model.CreatedDate = DateTime.Now;
                        Model.Image = ImgUploaded;
                        await busService.AddBusAsync(Model);
                        buses = await busService.GetBusesAsync();

                    }
                    else
                    {
                        Model.ModifiedDate = DateTime.Now;
                        Model.Image = ImgUploaded;
                        var busToUpdate = await busService.UpdateBusAsync(Model.BusId);
                        buses.Where(_ => _.BusId == Model.BusId).FirstOrDefault();
                        buses.Add(busToUpdate);
                        buses = await busService.GetBusesAsync();
                    }
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

                public async Task OpenDeleteModal(string modalId, int busItemId)
                {
                    busToDelete = busItemId;
                    await _jsRuntime.InvokeVoidAsync("global.openModal", modalId);
                }

                public async Task ConfirmDelete(string modalId)
                {
                    var busTodelete = buses.Where(_ => _.BusId == busToDelete).FirstOrDefault();
                    await busService.DeleteBusAsync(busToDelete);
                    buses.Remove(busTodelete);
                    await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
                }


            

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CarLot.Data.BusService busService { get; set; }
    }
}
#pragma warning restore 1591
