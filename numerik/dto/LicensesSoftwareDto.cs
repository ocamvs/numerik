using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik.mod
{
    public class LicensesSoftwareDto
    {
        public int Id {  get; set; }
        public string NamePo { get; set; }
        public string Manufacturer { get; set; }
        public string LicenseKey { get; set; }
        public DateTime EndDate { get; set; }
    }
}
