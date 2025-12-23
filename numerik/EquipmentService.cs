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
        DbSet<Division> Divisions;
        DbSet<Employee> Employees;
        DbSet<Equipment> Equipments;
        DbSet<MovementHistory> MovementHistorys;
        DbSet<InstalledSoftware> InstalledSoftwares;

        DbSet<EquipmentType> EquipmentTypes;

        DbSet<LicensesSoftware> LicensesSoftwares;

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

            modelBuilder.Entity
        }
            
    }
}
