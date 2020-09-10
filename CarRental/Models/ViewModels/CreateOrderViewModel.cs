using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.ViewModels
{
    public class CreateOrderViewModel
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Comment { get; set; }
        public Car Cars { get; set; }
    }
}
