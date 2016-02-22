﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

using D05.Controllers;

using D05.Models;

namespace D05.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Profile> Profile { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<CreateEvent> Event { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<CreateEvent> CreateEvent { get; set; }
        public DbSet<CouponProfile> CouponProfile { get; set; }

    }
}
