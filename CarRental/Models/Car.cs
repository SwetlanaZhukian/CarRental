using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string  Model { get; set; }
        public string  ClassOfCar { get; set; }
        public DateTime YearOfManufacture { get; set; }
        public string  NumberOfCarRegistration { get; set; }
        public double Price { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
