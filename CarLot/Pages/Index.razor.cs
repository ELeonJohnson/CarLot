using CarLot.Data;
using CarLot.Models;
using CarLot.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public List<Bus> FeaturedBuses { get; set; } = new List<Bus>();
        public List<Car> FeaturedCars { get; set; } = new List<Car>();
        public List<Motorcycle> FeaturedMotorcycles { get; set; } = new List<Motorcycle>();
        public List<SUV> FeaturedSuvs { get; set; } = new List<SUV>();
        public List<Truck> FeaturedTrucks { get; set; } = new List<Truck>();

        public string MakeOfBus { get; set; }
        public string MakeOfCar { get; set; }
        public string MakeOfMotorcycle { get; set; }
        public string MakeOfSUV { get; set; }
        public string MakeOfTruck { get; set; }
        public List<Bus> DisplayBusesByMake { get; set; } = new List<Bus>();
        public List<Car> DisplayCarsByMake { get; set; } = new List<Car>();
        public List<Motorcycle> DisplayMotorcyclesByMake { get; set; } = new List<Motorcycle>();
        public List<SUV> DisplaySUVsByMake { get; set; } = new List<SUV>();
        public List<Truck> DisplayTrucksByMake { get; set; } = new List<Truck>();
        public List<Bus> BusResults { get; set; } = new List<Bus>();
        public List<Car> CarResults { get; set; } = new List<Car>();
        public List<Motorcycle> MotorcycleResults { get; set; } = new List<Motorcycle>();
        public List<SUV> SUVResults { get; set; } = new List<SUV>();
        public List<Truck> TruckResults { get; set; } = new List<Truck>();






        protected override async Task OnInitializedAsync()
        {    
            FeaturedBuses = await busService.GetFeaturedBuses();
            FeaturedCars = await carService.GetFeaturedCars();
            FeaturedMotorcycles = await motorcycleService.GetFeaturedMotorcycles();
            FeaturedSuvs = await suvService.GetFeaturedSUVs();
            FeaturedTrucks = await truckService.GetFeaturedTrucks();

            DisplayBusesByMake = await busService.GetBusesAsync();
            DisplayCarsByMake = await carService.GetCarsAsync();
            DisplayMotorcyclesByMake = await motorcycleService.GetMotorcyclesAsync();
            DisplaySUVsByMake = await suvService.GetSUVsAsync();
            DisplayTrucksByMake = await truckService.GetTrucksAsync();
        }

        void ReturnBusesByMake(ChangeEventArgs e)
        {
            MakeOfBus = e.Value.ToString();
           
        }

        void ReturnCarsByMake(ChangeEventArgs e)
        {
            MakeOfCar = e.Value.ToString();

        }

        void ReturnMotorcyclesByMake(ChangeEventArgs e)
        {
            MakeOfMotorcycle = e.Value.ToString();

        }

        void ReturnSUVsByMake(ChangeEventArgs e)
        {
            MakeOfSUV = e.Value.ToString();

        }

        void ReturnTrucksByMake(ChangeEventArgs e)
        {
            MakeOfTruck = e.Value.ToString();

        }





    }
}
