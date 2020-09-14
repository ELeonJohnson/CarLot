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

        public async Task<List<SUV>> GetSUVsAsync()
        {
            return await _context.SUVs.ToListAsync();
        }

        public async Task<SUV> GetSUVsByIdAsync(int id)
        {
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
