using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DroneApplication.Models;

    public class DroneApplicationContext : DbContext
    {
        public DroneApplicationContext (DbContextOptions<DroneApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<DroneApplication.Models.CustomerDetails> CustomerDetails { get; set; }

        public DbSet<DroneApplication.Models.BookingDetails> BookingDetails { get; set; }
    }
