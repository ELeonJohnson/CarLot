using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarLot.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public List<SUV> SUVs { get; set; }
        public List<Bus> Buses { get; set; }
        public List<Motorcycle> Motorcycles { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Image")]
        public byte[] Image { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Number { get; set; }
        public string About { get; set; }
        [Display(Name = "Hours Of Business")]
        public string Hours { get; set; }

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}
