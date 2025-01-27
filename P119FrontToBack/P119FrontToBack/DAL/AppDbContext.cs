﻿using Microsoft.EntityFrameworkCore;
using P119FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P119FrontToBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider>  Sliders { get; set; }
        public DbSet<Caption> Captions { get; set; }
        public  DbSet<Category> Categories{ get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet <About> About { get; set; }

    }
}
