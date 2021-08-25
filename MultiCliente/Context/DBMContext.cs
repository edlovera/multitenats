using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MultiCliente.Models;
using MultiCliente.Models.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiCliente.Context
{
    public class DBMContext: DbContext
    {
        private string connectionString;

      
        public DBMContext(string connectionString)
        {
            this.connectionString = connectionString;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Cliente> Cliente { get; set; }


    }
}
