using System;
using System.Collections.Generic;
using System.Text;
using Hospital.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Carriers> Carriers { get; set; }
        public DbSet<OT> OTs { get; set; }
    }
}
