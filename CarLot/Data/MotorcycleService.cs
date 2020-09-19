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
            return await _context.Motorcycles.OrderByDescending(c => c.MotorcycleId).Take(2).ToListAsync();
        }

        public async Task<List<Motorcycle>> GetMotorcyclesAsync()
            {
                return await _context.Motorcycles.ToListAsync();
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

