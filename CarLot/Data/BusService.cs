using BlazorInputFile;
using CarLot.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
            return await _context.Buses.OrderByDescending(b => b.BusId).Take(2).ToListAsync();
        }


        public async Task<List<Bus>> GetBusByMakes(string makeOfBus)
        {
            return await _context.Buses.Where(bm => bm.Make == makeOfBus).ToListAsync();
        }

        public async Task<List<Bus>> GetBusesAsync()
        {
            return await _context.Buses.ToListAsync();
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

