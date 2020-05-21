using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int zipCode { get; set; }
       // public DateTime currentDay { get; set; }
       


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
