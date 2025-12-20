using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik.mod
{
    public class EquipmentType
    {
        public int Id { get; set; }
        public EquipmentT EType { get; set; }
    }
    public enum EquipmentT
    {
        SystemUnit  = 0,
        monitor = 1,
        printer = 2
    }
}
