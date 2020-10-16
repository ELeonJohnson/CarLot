using BlazorInputFile;
using CarLot.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using static CarLot.Data.BusService;
using static System.Net.Mime.MediaTypeNames;

namespace CarLot.Data
{
    public class BusService 
    {
        ApplicationDbContext _context;
        UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public BusService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }


        public async Task<List<Bus>> GetFeaturedBuses()
        {
            
            return await _context.Buses.Include(r => r.ApplicationUser).OrderByDescending(b => b.BusId).Take(2).ToListAsync();
        }

        public async Task<List<Bus>> GetFilteredBuses(string makeOfBus, string priceOfBus, 
            string mileageOfBus, int? yearOfBus, string bodyStyleOfBus, string extColorOfBus,
            string intColorOfBus, string driveTrainOfBus, string transmissionOfBus,
            string cylindersOfBus, string fuelOfBus, string doorCountOfBus, string searchString)
        {
            var buses = from b in _context.Buses
                        select b;


            if (!string.IsNullOrEmpty(makeOfBus))
            {
                buses = buses.Where(bm => bm.Make == makeOfBus);
            }
            else
            {
                makeOfBus = "";
            }


            if (!string.IsNullOrEmpty(priceOfBus))
            {
                buses = buses.Where(bp => bp.Price == priceOfBus);
            }
            else
            {
                priceOfBus = "";
            }

            if (!string.IsNullOrEmpty(mileageOfBus))
            {
                buses = buses.Where(bmi => bmi.Mileage == mileageOfBus);
            }
            else 
            {
                mileageOfBus = "";
            }

            if (!string.IsNullOrEmpty(Convert.ToString(yearOfBus)))
            {
                buses = buses.Where(by => by.Year == yearOfBus);
            }
            else
            {
                yearOfBus = 0;
            }

            if (!string.IsNullOrEmpty(bodyStyleOfBus))
            {
                buses = buses.Where(bs => bs.BodyStyle == bodyStyleOfBus);
            }
            else
            {
                bodyStyleOfBus = "";
            }


            if (!string.IsNullOrEmpty(extColorOfBus))
            {
                buses = buses.Where(bec => bec.ExteriorColor == extColorOfBus);
            }
            else
            {
                extColorOfBus = "";
            }

            if (!string.IsNullOrEmpty(intColorOfBus))
            {
                buses = buses.Where(bit => bit.InteriorColor == intColorOfBus);
            }
            else
            {
                intColorOfBus = "";
            }

            if (!string.IsNullOrEmpty(driveTrainOfBus))
            {
                buses = buses.Where(dt => dt.DriveTrain == driveTrainOfBus);
            }
            else
            {
                driveTrainOfBus = "";
            }

            if (!string.IsNullOrEmpty(transmissionOfBus))
            {
                buses = buses.Where(t => t.Transmission == transmissionOfBus);
            }
            else
            {
                transmissionOfBus = "";
            }

            if (!string.IsNullOrEmpty(cylindersOfBus))
            {
                buses = buses.Where(c => c.Cylinders == cylindersOfBus);
            }
            else
            {
                cylindersOfBus = "";
            }

            if (!string.IsNullOrEmpty(fuelOfBus))
            {
                buses = buses.Where(f => f.Fuel == fuelOfBus);
            }
            else
            {
                fuelOfBus = "";
            }

            if (!string.IsNullOrEmpty(doorCountOfBus))
            {
                buses = buses.Where(dc => dc.DoorCount == doorCountOfBus);
            }
            else
            {
                doorCountOfBus = "";
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                buses = buses.Where(bm => bm.Make.Contains(searchString));

            }





            return await buses.OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

    

        public async Task<List<Bus>> GetBusesAsync()
        {
            return await _context.Buses.Include(r => r.ApplicationUser).OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

        public async Task<Bus> GetBusByIdAsync(int id)
        {
            var user = _context.Buses.Include(r => r.ApplicationUser).Where(r => r.BusId == id).FirstOrDefault();

            return await _context.Buses.FindAsync(id);
        }

        public async Task<Bus> AddBusAsync(Bus bus)
        {


            var applicationUserId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);

            bus.ApplicationUserId = Convert.ToInt32(applicationUserId);


            _context.Buses.Add(bus);
            await _context.SaveChangesAsync();

            return bus;
        }

        public async Task<Bus> UpdateBusAsync(int id)
        {
            var bus = await _context.Buses.FindAsync(id);

                     

            _context.Buses.Update(bus);
            await _context.SaveChangesAsync();

            return bus;
        }

        public async Task<Bus> DeleteBusAsync(int id)
        {
            var bus = await _context.Buses.FindAsync(id);

            if (bus == null)
                return null;

            _context.Buses.Remove(bus);
            await _context.SaveChangesAsync();

            return bus;
        }

        private bool BusExists(int id)
        {
            return _context.Buses.Any(e => e.BusId == id);
        }
    }
}

