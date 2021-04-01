﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;

namespace DataAccess.Concrete.EntityFramework
{       
    //Context :Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext //DbContext kendiliğinden var yükleyince geliyor
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\ProjectsV13;Database=RentaCarContext;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Color { get; set; }
    }
}
