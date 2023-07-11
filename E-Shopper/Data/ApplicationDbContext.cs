﻿using E_Shopper.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Shopper.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products{get;set;}
        public DbSet<Color> Colors { get;set;}
        public DbSet<Category> Categories { get;set;}
        public DbSet<Size> Sizes { get;set;}
    }
}