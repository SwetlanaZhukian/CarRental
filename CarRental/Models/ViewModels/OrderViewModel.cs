using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Mark { get; set; }
        public string Model{ get; set; }
        public double Price { get; set; }
        public string Comment { get; set; }
        public OrderViewModel()
        {

        }


    }
}
