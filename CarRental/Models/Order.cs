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
        public User User { get; set; }

        public List<Car> Cars { get; set; }
    }
}
