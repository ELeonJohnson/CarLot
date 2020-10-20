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

        public async Task<List<Car>> GetFeaturedCars()
        {
            return await _context.Cars.Include(r => r.ApplicationUser).OrderByDescending(c => c.CarId).Take(2).ToListAsync();
        }

        public async Task<List<Car>> GetFilteredCars(string makeOfCar, string priceOfCar,
           string mileageOfCar, int? yearOfCar, string bodyStyleOfCar, string extColorOfCar,
           string intColorOfCar, string driveTrainOfCar, string transmissionOfCar,
           string cylindersOfCar, string fuelOfCar, string doorCountOfCar, string searchString)
        {
            var cars = from c in _context.Cars
                        select c;


            if (!string.IsNullOrEmpty(makeOfCar))
            {
                cars = cars.Where(cm => cm.Make == makeOfCar);
            }
            else
            {
                makeOfCar = "";
            }


            if (!string.IsNullOrEmpty(priceOfCar))
            {
                cars = cars.Where(cp => cp.Price == priceOfCar);
            }
            else
            {
                priceOfCar = "";
            }

            if (!string.IsNullOrEmpty(mileageOfCar))
            {
                cars = cars.Where(cmi => cmi.Mileage == mileageOfCar);
            }
            else
            {
                mileageOfCar = "";
            }

            if (!string.IsNullOrEmpty(Convert.ToString(yearOfCar)))
            {
                cars = cars.Where(cy => cy.Year == yearOfCar);
            }
            else
            {
                yearOfCar = 0;
            }

            if (!string.IsNullOrEmpty(bodyStyleOfCar))
            {
                cars = cars.Where(cs => cs.BodyStyle == bodyStyleOfCar);
            }
            else
            {
                bodyStyleOfCar = "";
            }


            if (!string.IsNullOrEmpty(extColorOfCar))
            {
                cars = cars.Where(cec => cec.ExteriorColor == extColorOfCar);
            }
            else
            {
                extColorOfCar = "";
            }

            if (!string.IsNullOrEmpty(intColorOfCar))
            {
                cars = cars.Where(cit => cit.InteriorColor == intColorOfCar);
            }
            else
            {
                intColorOfCar = "";
            }

            if (!string.IsNullOrEmpty(driveTrainOfCar))
            {
                cars = cars.Where(ct => ct.DriveTrain == driveTrainOfCar);
            }
            else
            {
                driveTrainOfCar = "";
            }

            if (!string.IsNullOrEmpty(transmissionOfCar))
            {
                cars = cars.Where(t => t.Transmission == transmissionOfCar);
            }
            else
            {
                transmissionOfCar = "";
            }

            if (!string.IsNullOrEmpty(cylindersOfCar))
            {
                cars = cars.Where(c => c.Cylinders == cylindersOfCar);
            }
            else
            {
                cylindersOfCar = "";
            }

            if (!string.IsNullOrEmpty(fuelOfCar))
            {
                cars = cars.Where(f => f.Fuel == fuelOfCar);
            }
            else
            {
                fuelOfCar = "";
            }

            if (!string.IsNullOrEmpty(doorCountOfCar))
            {
                cars = cars.Where(dc => dc.DoorCount == doorCountOfCar);
            }
            else
            {
                doorCountOfCar = "";
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(bm => bm.Make.Contains(searchString));

            }

            return await cars.OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

        public async Task<List<Car>> GetCarsAsync()
        {
            return await _context.Cars.Include(r => r.ApplicationUser).OrderByDescending(b => b.CreatedDate).ToListAsync();
        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            var user = _context.Cars.Include(r => r.ApplicationUser).Where(r => r.CarId == id).FirstOrDefault();

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

