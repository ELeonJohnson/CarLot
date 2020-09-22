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
            return await _context.Trucks.OrderByDescending(c => c.TruckId).Take(2).ToListAsync();
        }

        public async Task<List<Truck>> GetTruckByMakes(string makeOfTruck)
        {
            return await _context.Trucks.Where(tm => tm.Make == makeOfTruck).OrderByDescending(t => t.CreatedDate).ToListAsync();
        }

        public async Task<List<Truck>> GetTrucksAsync()
        {
            return await _context.Trucks.ToListAsync();
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
