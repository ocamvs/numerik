using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using numerik.mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik.config.TypeModConfig
{
    public class EquipmentTypeConfig : IEntityTypeConfiguration<EquipmentTypeDto>
    {
        public void Configure(EntityTypeBuilder<EquipmentTypeDto> builder)
        {
            builder.HasKey(e => e.Id);


        }
    }
}
