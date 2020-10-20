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
    public class SUVService
    {
        ApplicationDbContext _context;
        UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SUVService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<SUV>> GetFeaturedSUVs()
        {
            return await _context.SUVs.Include(r => r.ApplicationUser).OrderByDescending(c => c.SUVId).Take(2).ToListAsync();
        }

        public async Task<List<SUV>> GetFilteredSUVs(string makeOfSUV, string priceOfSUV,
           string mileageOfSUV, int? yearOfSUV, string bodyStyleOfSUV, string extColorOfSUV,
           string intColorOfSUV, string driveTrainOfSUV, string transmissionOfSUV,
           string cylindersOfSUV, string fuelOfSUV, string doorCountOfSUV, string searchString)
        {
            var suvs = from s in _context.SUVs
                       select s;


            if (!string.IsNullOrEmpty(makeOfSUV))
            {
                suvs = suvs.Where(cm => cm.Make == makeOfSUV);
            }
            else
            {
                makeOfSUV = "";
            }


            if (!string.IsNullOrEmpty(priceOfSUV))
            {
                suvs = suvs.Where(cp => cp.Price == priceOfSUV);
            }
            else
            {
                priceOfSUV = "";
            }

            if (!string.IsNullOrEmpty(mileageOfSUV))
            {
                suvs = suvs.Where(cmi => cmi.Mileage == mileageOfSUV);
            }
            else
            {
                mileageOfSUV = "";
            }

            if (!string.IsNullOrEmpty(Convert.ToString(yearOfSUV)))
            {
                suvs = suvs.Where(cy => cy.Year == yearOfSUV);
            }
            else
            {
                yearOfSUV = 0;
            }

            if (!string.IsNullOrEmpty(bodyStyleOfSUV))
            {
                suvs = suvs.Where(cs => cs.BodyStyle == bodyStyleOfSUV);
            }
            else
            {
                bodyStyleOfSUV = "";
            }


            if (!string.IsNullOrEmpty(extColorOfSUV))
            {
                suvs = suvs.Where(cec => cec.ExteriorColor == extColorOfSUV);
            }
            else
            {
                extColorOfSUV = "";
            }

            if (!string.IsNullOrEmpty(intColorOfSUV))
            {
                suvs = suvs.Where(cit => cit.InteriorColor == intColorOfSUV);
            }
            else
            {
                intColorOfSUV = "";
            }

            if (!string.IsNullOrEmpty(driveTrainOfSUV))
            {
                suvs = suvs.Where(ct => ct.DriveTrain == driveTrainOfSUV);
            }
            else
            {
                driveTrainOfSUV = "";
            }

            if (!string.IsNullOrEmpty(transmissionOfSUV))
            {
                suvs = suvs.Where(t => t.Transmission == transmissionOfSUV);
            }
            else
            {
                transmissionOfSUV = "";
            }

            if (!string.IsNullOrEmpty(cylindersOfSUV))
            {
                suvs = suvs.Where(c => c.Cylinders == cylindersOfSUV);
            }
            else
            {
                cylindersOfSUV = "";
            }

            if (!string.IsNullOrEmpty(fuelOfSUV))
            {
                suvs = suvs.Where(f => f.Fuel == fuelOfSUV);
            }
            else
            {
                fuelOfSUV = "";
            }

            if (!string.IsNullOrEmpty(doorCountOfSUV))
            {
                suvs = suvs.Where(dc => dc.DoorCount == doorCountOfSUV);
            }
            else
            {
                doorCountOfSUV = "";
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                suvs = suvs.Where(bm => bm.Make.Contains(searchString));

            }

            return await suvs.OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

        public async Task<List<SUV>> GetSUVsAsync()
        {
            return await _context.SUVs.Include(r => r.ApplicationUser).OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

        public async Task<SUV> GetSUVByIdAsync(int id)
        {
            var user = _context.SUVs.Include(r => r.ApplicationUser).Where(r => r.SUVId == id).FirstOrDefault();

            return await _context.SUVs.FindAsync(id);
        }

        public async Task<SUV> AddSUVAsync(SUV suv)
        {
            var applicationUserId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);

            suv.ApplicationUserId = Convert.ToInt32(applicationUserId);

            _context.SUVs.Add(suv);
            await _context.SaveChangesAsync();

            return suv;
        }

        public async Task<SUV> UpdateSUVAsync(int id)
        {
            var suv = await _context.SUVs.FindAsync(id);

           


            _context.SUVs.Update(suv);
            await _context.SaveChangesAsync();

            return suv;
        }

        public async Task<SUV> DeleteSUVAsync(int id)
        {
            var suv = await _context.SUVs.FindAsync(id);

            if (suv == null)
                return null;

            _context.SUVs.Remove(suv);
            await _context.SaveChangesAsync();

            return suv;
        }

        private bool SUVExists(int id)
        {
            return _context.SUVs.Any(e => e.SUVId == id);
        }
    }
}
