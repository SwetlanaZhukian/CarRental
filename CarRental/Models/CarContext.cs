﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Models
{
    public class CarContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public CarContext(DbContextOptions<CarContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
