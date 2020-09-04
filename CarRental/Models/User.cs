using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CarRental.Models
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NumberOfDriverLicense{ get; set; }

        public List<Order> Orders{ get; set; }

    }
}
