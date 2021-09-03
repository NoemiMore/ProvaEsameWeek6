using Microsoft.EntityFrameworkCore;
using ProvaWeek6.Core.Models;
using ProvaWeek6.EF.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek6.EF.Repository
{
    class PolizzaContext: DbContext
    {

        public DbSet<Cliente> Clienti { get; set; }

        public DbSet<Polizza> Polizze { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
		Database=GestioneClienti;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());

            
        }

    }
}
