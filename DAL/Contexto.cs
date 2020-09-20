using Microsoft.EntityFrameworkCore;
using PersonaBlazor.Models;
using System;

namespace PersonaBlazor.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\Personas.db");
        }
       
    }
}