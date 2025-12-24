using Microsoft.EntityFrameworkCore;
using numerik.mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik
{
    public class Context : DbContext
    {
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<MovementHistory> MovementHistorys { get; set; }
        public DbSet<InstalledSoftware> InstalledSoftwares { get; set; }

        public DbSet<EquipmentType> EquipmentTypes { get; set; }

        public DbSet<LicensesSoftware> LicensesSoftwares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "server=localhost;port=3306;database=LibraryDB;user=root;password=;CharSet=utf8mb4;";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Division>(e=>e.)
        }
            
    }
}
