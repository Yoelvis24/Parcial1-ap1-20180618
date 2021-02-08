using System;
using System.Collections.Generic;
using System.Text;
using Parcial1_ap1_20180618.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Parcial1_ap1_20180618.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ciudades> Ciudades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionCiudades.Db");
        }
    }
}
