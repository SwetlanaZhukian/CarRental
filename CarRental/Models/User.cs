using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NumberOfDriverLicense{ get; set; }

        public List<Order> Orders{ get; set; }

    }
}
