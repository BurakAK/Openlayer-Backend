using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class MapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Map;Trusted_Connection=true");
        }
        public DbSet<Mahalle> Mahalles { get; set; }//Mahalle Tablosu

        public DbSet<Kapi> Kapi { get; set; }//Kapı Tablosu

    }
}
