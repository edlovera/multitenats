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
    public class DBContext: DbContext
    {
        public string connectionString;

        public DBContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DBContext(DbContextOptions<DBContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Test> Test { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<BioData> BioData { get; set; }


    }
}
