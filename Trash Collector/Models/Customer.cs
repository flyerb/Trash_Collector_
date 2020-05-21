using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string streetAddress { get; set; }
        public int zipCode { get; set; }

        public string weeklyPickupDay { get; set; }
        public DateTime extraPickup { get; set; }
        public DateTime suspendPickupStart { get; set; }
        public DateTime suspendPickupEnd { get; set; }
        public double invoice { get; set; }
       


        [ForeignKey("IdentityUser")] 
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        

    }
}
