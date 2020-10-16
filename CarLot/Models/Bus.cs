﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CarLot.Models
{
    public class Bus
    {
        public int BusId { get; set; }
        [Display(Name = "Home Delivery")]
        public bool HomeDelivery { get; set; }
        [Display(Name = "Virtual Appointments")]
        public bool VirtualAppointments { get; set; }
        public bool New { get; set; }
        public bool Used { get; set; }
        [Display(Name = "Certifies Pre-Owned")]
        public bool CertifiedPreOwned { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Price { get; set; }
        public string Mileage { get; set; }
        public string Features { get; set; }
        [Display(Name = "Body Style")]
        public string BodyStyle { get; set; }
        [Display(Name = "Exterior Color")]
        public string ExteriorColor { get; set; }
        [Display(Name = "Interior Color")]
        public string InteriorColor { get; set; }
        [Display(Name ="Drivetrain")]
        public string DriveTrain { get; set; }
        public string Transmission { get; set; }
        public string Cylinders { get; set; }
        public string Fuel { get; set; }
        [Display(Name ="Door Count")]
        public string DoorCount { get; set; }
        [Display(Name ="Seller Notes")]
        public string SellerNotes { get; set; }
        [Display(Name = "dddd, MMMM dd, yyyy HH:mm tt")]
        public DateTime? ModifiedDate { get; set; }
        [Display(Name = "dddd, MMMM dd, yyyy HH:mm tt")]
        public DateTime? CreatedDate { get; set; }
        public byte[] Image { get; set; }




        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
    }
}
