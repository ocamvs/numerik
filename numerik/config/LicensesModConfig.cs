using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using numerik.mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik.config
{
    public class LicensesSoftwareConfig : IEntityTypeConfiguration<LicensesSoftware>
    {
        public void Configure(EntityTypeBuilder<LicensesSoftware> builder)
        {
            throw new NotImplementedException();
        }
    }
}
