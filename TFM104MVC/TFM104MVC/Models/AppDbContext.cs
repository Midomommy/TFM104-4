﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFM104MVC.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> _options) : base(_options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}