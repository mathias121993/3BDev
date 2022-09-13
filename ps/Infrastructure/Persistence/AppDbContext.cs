﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
    //MODELADO DE ENTIDADES -> Cardinalidad
    //protected override void OnModelCreating(ModelBuilder modelBuilder) { }
}
