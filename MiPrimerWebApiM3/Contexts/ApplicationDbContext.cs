﻿using Microsoft.EntityFrameworkCore;
using MiPrimerWebApiM3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Contexts
{
    public class ApplicationDbContext: DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        // Autores es la tabla de la base de datos, Autor es la clase
        public DbSet<Autor> Autores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var autores = new List<Autor>()
            {
                new Autor(){Id = 1, Nombre = "Felipe Gavilán" },
                new Autor(){Id = 2, Nombre = "Claudia Rodríguez" }
            };

            modelBuilder.Entity<Autor>().HasData(autores);

            base.OnModelCreating(modelBuilder);
        }
    }
}
