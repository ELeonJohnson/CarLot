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
    public class MotorcycleService
    {

            ApplicationDbContext _context;
            UserManager<ApplicationUser> _userManager;
            private readonly IHttpContextAccessor _httpContextAccessor;

        public MotorcycleService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
            {
                _context = context;
                _userManager = userManager;
                _httpContextAccessor = httpContextAccessor;

        }

        public async Task<List<Motorcycle>> GetFeaturedMotorcycles()
        {
            return await _context.Motorcycles.Include(r => r.ApplicationUser).OrderByDescending(c => c.MotorcycleId).Take(2).ToListAsync();
        }

        public async Task<List<Motorcycle>> GetFilteredMotorcycles(string makeOfMotorcycle, string priceOfMotorcycle,
          string mileageOfMotorcycle, int? yearOfMotorcycle, string bodyStyleOfMotorcycle, string extMotorcycle,
          string driveTrainOfMotorcycle, string transmissionOfMotorcycle,string cylindersOfMotorcycle, string fuelOfMotorcycle,string searchString)
        {
            var motorcycles = from m in _context.Motorcycles
                              select m;


            if (!string.IsNullOrEmpty(makeOfMotorcycle))
            {
                motorcycles = motorcycles.Where(mm => mm.Make == makeOfMotorcycle);
            }
            else
            {
                makeOfMotorcycle = "";
            }


            if (!string.IsNullOrEmpty(priceOfMotorcycle))
            {
                motorcycles = motorcycles.Where(mp => mp.Price == priceOfMotorcycle);
            }
            else
            {
                priceOfMotorcycle = "";
            }

            if (!string.IsNullOrEmpty(mileageOfMotorcycle))
            {
                motorcycles = motorcycles.Where(mmi => mmi.Mileage == mileageOfMotorcycle);
            }
            else
            {
                mileageOfMotorcycle = "";
            }

            if (!string.IsNullOrEmpty(Convert.ToString(yearOfMotorcycle)))
            {
                motorcycles = motorcycles.Where(my => my.Year == yearOfMotorcycle);
            }
            else
            {
                yearOfMotorcycle = 0;
            }

            if (!string.IsNullOrEmpty(bodyStyleOfMotorcycle))
            {
                motorcycles = motorcycles.Where(ms => ms.BodyStyle == bodyStyleOfMotorcycle);
            }
            else
            {
                bodyStyleOfMotorcycle = "";
            }

            if (!string.IsNullOrEmpty(driveTrainOfMotorcycle))
            {
                motorcycles = motorcycles.Where(mt => mt.DriveTrain == driveTrainOfMotorcycle);
            }
            else
            {
                driveTrainOfMotorcycle = "";
            }

            if (!string.IsNullOrEmpty(transmissionOfMotorcycle))
            {
                motorcycles = motorcycles.Where(t => t.Transmission == transmissionOfMotorcycle);
            }
            else
            {
                transmissionOfMotorcycle = "";
            }

            if (!string.IsNullOrEmpty(cylindersOfMotorcycle))
            {
                motorcycles = motorcycles.Where(c => c.Cylinders == cylindersOfMotorcycle);
            }
            else
            {
                cylindersOfMotorcycle = "";
            }

            if (!string.IsNullOrEmpty(fuelOfMotorcycle))
            {
                motorcycles = motorcycles.Where(f => f.Fuel == fuelOfMotorcycle);
            }
            else
            {
                fuelOfMotorcycle = "";
            }

            if (!string.IsNullOrEmpty(extMotorcycle))
            {
                motorcycles = motorcycles.Where(f => f.ExteriorColor == extMotorcycle);
            }
            else
            {
                extMotorcycle = "";
            }



            if (!string.IsNullOrEmpty(searchString))
            {
                motorcycles = motorcycles.Where(mm => mm.Make.Contains(searchString));

            }

            return await motorcycles.OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

        public async Task<List<Motorcycle>> GetMotorcyclesAsync()
            {
                return await _context.Motorcycles.Include(r => r.ApplicationUser).OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

            

            public async Task<Motorcycle> GetMotorcycleByIdAsync(int id)
            {
            var user = _context.Motorcycles.Include(r => r.ApplicationUser).Where(r => r.MotorcycleId == id).FirstOrDefault();

            return await _context.Motorcycles.FindAsync(id);
            }

            public async Task<Motorcycle> AddMotorcycleAsync(Motorcycle motorcycle)
            {
            var applicationUserId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);

            motorcycle.ApplicationUserId = Convert.ToInt32(applicationUserId);

            _context.Motorcycles.Add(motorcycle);
                await _context.SaveChangesAsync();

                return motorcycle;
            }

            public async Task<Motorcycle> UpdateMotorcycleAsync(int id)
            {
                var motorcycle = await _context.Motorcycles.FindAsync(id);



                _context.Motorcycles.Update(motorcycle);
                await _context.SaveChangesAsync();

                return motorcycle;
            }

            public async Task<Motorcycle> DeleteMotorcycleAsync(int id)
            {
                var motorcycle = await _context.Motorcycles.FindAsync(id);

                if (motorcycle == null)
                    return null;

                _context.Motorcycles.Remove(motorcycle);
                await _context.SaveChangesAsync();

                return motorcycle;
            }

            private bool MotocycleExists(int id)
            {
                return _context.Motorcycles.Any(e => e.MotorcycleId == id);
            }
        }
    }

