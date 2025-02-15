﻿using GadgetsStoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GadgetsStoreMVC.Services
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
