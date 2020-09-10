using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Comment  { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual List<Car> Cars { get; set; }

        public Order()
        {
            Cars = new List<Car>();
        }
    }
}
