using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using numerik.mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik.config.EquipmentModConfig
{
    public class DivisionConfig : IEntityTypeConfiguration<Division>
    {
        public void Configure(EntityTypeBuilder<Division> builder)
        {
            builder.ToTable("Подразделения");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasColumnName("division_name").HasMaxLength(30).IsRequired();
            builder.Property(e => e.Supervisor).HasColumnName("supervisor_fio").HasMaxLength(30).IsRequired();
        }
    }

    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Работники");
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(e => e.FIO).HasColumnName("fio").HasMaxLength(30).IsRequired();
            builder.Property(e => e.JobTitle).HasColumnName("job").HasMaxLength(30).IsRequired();
            builder.Property(e => e.DivisionId).HasColumnName("fio").HasMaxLength(30).IsRequired();
        }
    }

    public class EquipmentConfig : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable("Оборудывание");
            builder.HasKey(x => x.Id);


        }
    }

    public class MovementHistoryConfig : IEntityTypeConfiguration<MovementHistory>
    {
        public void Configure(EntityTypeBuilder<MovementHistory> builder)
        {
            builder.ToTable("История перемещения");
            builder.HasKey(x => x.Id);


        }
    }
    public class InstalledSoftwareConfig : IEntityTypeConfiguration<InstalledSoftware>
    {
        public void Configure(EntityTypeBuilder<InstalledSoftware> builder)
        {
            builder.ToTable("Установленное по");
            builder.HasKey(x => x.Id);


        }
    }
}
