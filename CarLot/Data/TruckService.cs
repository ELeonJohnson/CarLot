using CarLot.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarLot.Data
{
    public class TruckService
    {
        ApplicationDbContext _context;
        UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TruckService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }

        public async Task<List<Truck>> GetFeaturedTrucks()
        {
            return await _context.Trucks.Include(r => r.ApplicationUser).OrderByDescending(c => c.TruckId).Take(2).ToListAsync();
        }

        public async Task<List<Truck>> GetFilteredTrucks(string makeOfTruck, string priceOfTruck,
           string mileageOfTruck, int? yearOfTruck, string bodyStyleOfTruck, string extColorOfTruck,
           string intColorOfTruck, string driveTrainOfTruck, string transmissionOfTruck,
           string cylindersOfTruck, string fuelOfTruck, string doorCountOfTruck, string searchString)
        {
            var trucks = from t in _context.Trucks
                        select t;


            if (!string.IsNullOrEmpty(makeOfTruck))
            {
                trucks = trucks.Where(tm => tm.Make == makeOfTruck);
            }
            else
            {
                makeOfTruck = "";
            }


            if (!string.IsNullOrEmpty(priceOfTruck))
            {
                trucks = trucks.Where(tp => tp.Price == priceOfTruck);
            }
            else
            {
                priceOfTruck = "";
            }

            if (!string.IsNullOrEmpty(mileageOfTruck))
            {
                trucks = trucks.Where(tmi => tmi.Mileage == mileageOfTruck);
            }
            else
            {
                mileageOfTruck = "";
            }

            if (!string.IsNullOrEmpty(Convert.ToString(yearOfTruck)))
            {
                trucks = trucks.Where(ty => ty.Year == yearOfTruck);
            }
            else
            {
                yearOfTruck = 0;
            }

            if (!string.IsNullOrEmpty(bodyStyleOfTruck))
            {
                trucks = trucks.Where(bs => bs.BodyStyle == bodyStyleOfTruck);
            }
            else
            {
                bodyStyleOfTruck = "";
            }


            if (!string.IsNullOrEmpty(extColorOfTruck))
            {
                trucks = trucks.Where(bec => bec.ExteriorColor == extColorOfTruck);
            }
            else
            {
                extColorOfTruck = "";
            }

            if (!string.IsNullOrEmpty(intColorOfTruck))
            {
                trucks = trucks.Where(bit => bit.InteriorColor == intColorOfTruck);
            }
            else
            {
                intColorOfTruck = "";
            }

            if (!string.IsNullOrEmpty(driveTrainOfTruck))
            {
                trucks = trucks.Where(dt => dt.DriveTrain == driveTrainOfTruck);
            }
            else
            {
                driveTrainOfTruck = "";
            }

            if (!string.IsNullOrEmpty(transmissionOfTruck))
            {
                trucks = trucks.Where(t => t.Transmission == transmissionOfTruck);
            }
            else
            {
                transmissionOfTruck = "";
            }

            if (!string.IsNullOrEmpty(cylindersOfTruck))
            {
                trucks = trucks.Where(c => c.Cylinders == cylindersOfTruck);
            }
            else
            {
                cylindersOfTruck = "";
            }

            if (!string.IsNullOrEmpty(fuelOfTruck))
            {
                trucks = trucks.Where(f => f.Fuel == fuelOfTruck);
            }
            else
            {
                fuelOfTruck = "";
            }

            if (!string.IsNullOrEmpty(doorCountOfTruck))
            {
                trucks = trucks.Where(dc => dc.DoorCount == doorCountOfTruck);
            }
            else
            {
                doorCountOfTruck = "";
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                trucks = trucks.Where(bm => bm.Make.Contains(searchString));

            }

            return await trucks.OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

        public async Task<List<Truck>> GetTrucksAsync()
        {
            return await _context.Trucks.Include(r => r.ApplicationUser).OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

        public async Task<Truck> GetTruckByIdAsync(int id)
        {
            var user = _context.Trucks.Include(r => r.ApplicationUser).Where(r => r.TruckId == id).FirstOrDefault();

            return await _context.Trucks.FindAsync(id);
        }

        public async Task<Truck> AddTruckAsync(Truck truck)
        {
            var applicationUserId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);

            truck.ApplicationUserId = Convert.ToInt32(applicationUserId);

            _context.Trucks.Add(truck);
            await _context.SaveChangesAsync();

            return truck;
        }

        public async Task<Truck> UpdateTruckAsync(int id)
        {
            var truck = await _context.Trucks.FindAsync(id);



            _context.Trucks.Update(truck);
            await _context.SaveChangesAsync();

            return truck;
        }

        public async Task<Truck> DeleteTruckAsync(int id)
        {
            var truck = await _context.Trucks.FindAsync(id);

            if (truck == null)
                return null;

            _context.Trucks.Remove(truck);
            await _context.SaveChangesAsync();

            return truck;
        }

        private bool TruckExists(int id)
        {
            return _context.Trucks.Any(e => e.TruckId == id);
        }
    }
}
