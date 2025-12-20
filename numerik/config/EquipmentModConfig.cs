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
            builder.HasKey(x => x.Id);


        }
    }

    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);


        }
    }

    public class EquipmentConfig : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasKey(x => x.Id);


        }
    }

    public class MovementHistoryConfig : IEntityTypeConfiguration<MovementHistory>
    {
        public void Configure(EntityTypeBuilder<MovementHistory> builder)
        {
            builder.HasKey(x => x.Id);


        }
    }
    public class InstalledSoftwareConfig : IEntityTypeConfiguration<InstalledSoftware>
    {
        public void Configure(EntityTypeBuilder<InstalledSoftware> builder)
        {
            builder.HasKey(x => x.Id);


        }
    }
}
