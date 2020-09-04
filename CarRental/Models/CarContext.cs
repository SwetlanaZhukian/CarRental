using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CarRental.Models
{
    public class CarContext: IdentityDbContext<User>
    {
        public DbSet<Car> Cars { get; set; }
       // public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public CarContext(DbContextOptions<CarContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
