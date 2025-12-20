using Microsoft.EntityFrameworkCore;
using numerik.mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik
{
    public class EquipmentService: DbContext
    {
        DbSet<Division> Divisions;
        DbSet<Employee> Employees;
        DbSet<Equipment> Equipments;
        DbSet<MovementHistory> MovementHistorys;
        DbSet<InstalledSoftware> InstalledSoftwares;

        DbSet<EquipmentType> EquipmentTypes;

        DbSet<LicensesSoftware> LicensesSoftwares;

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Division>(entity =>
        //    {
        //        entity.
        //    });
        //}
    }
}
