using CarLot.Data;
using CarLot.Models;
using CarLot.Pages;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CarLot.Pages
{
    public partial class Index : ComponentBase
    {

        [Inject]
        public BusService busService { get; set; }
        [Inject]
        public CarService carService { get; set; }
        [Inject]
        public MotorcycleService motorcycleService { get; set; }
        [Inject]
        public SUVService suvService { get; set; }
        [Inject]
        public TruckService truckService { get; set; }


        public List<Bus> buses { get; set; } = new List<Bus>();
        public List<Car> cars { get; set; } = new List<Car>();
        public List<Motorcycle> motorcycles { get; set; } = new List<Motorcycle>();
        public List<SUV> suvs { get; set; } = new List<SUV>();
        public List<Truck> trucks { get; set; } = new List<Truck>();

        



        protected override async Task OnInitializedAsync()
        {

            buses = await busService.GetFeaturedBuses();
            cars = await carService.GetFeaturedCars();
            motorcycles = await motorcycleService.GetFeaturedMotorcycles();
            suvs = await suvService.GetFeaturedSUVs();
            trucks = await truckService.GetFeaturedTrucks();

        }


    }
}
