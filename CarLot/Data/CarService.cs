﻿using CarLot.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarLot.Data
{
    public class CarService
    {
        ApplicationDbContext _context;
        UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CarService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            return await _context.Cars.FindAsync(id);
        }

        public async Task<Car> AddCarAsync(Car car)
        {
            var applicationUserId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);

            car.ApplicationUserId = Convert.ToInt32(applicationUserId);

            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return car;
        }

        public async Task<Car> UpdateCarAsync(int id)
        {
            var car = await _context.Cars.FindAsync(id);

           


            _context.Cars.Update(car);
            await _context.SaveChangesAsync();

            return car;
        }

        public async Task<Car> DeleteCarAsync(int id)
        {
            var car = await _context.Cars.FindAsync(id);

            if (car == null)
                return null;

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return car;
        }

        public bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.CarId == id);
        }
    }

}

