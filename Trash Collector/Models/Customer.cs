using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        [Display(Name ="First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Address")]
        public string streetAddress { get; set; }

        [Display(Name = "Zip Code")]
        public int zipCode { get; set; }


        [Display(Name = "Pick up Complete")]
        public bool pickUpComplete { get; set; }

        [Display(Name = "Pick Up Day")]
        public string weeklyPickupDay { get; set; }

        [Display(Name = "Once Additional Pick up Day")]
        public DateTime extraPickup { get; set; }

        [Display(Name = "Suspended Start Date")]
        public DateTime suspendPickupStart { get; set; }

        [Display(Name = "Suspended End Date")]
        public DateTime suspendPickupEnd { get; set; }

        [Display(Name = "Invoice")]
        public double invoice { get; set; }


        [ForeignKey("IdentityUser")] 
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        

    }
}
