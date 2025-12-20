using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik.mod
{
    public abstract class Dto
    {
        protected List<Dto> item;
        public abstract string GetName();
        public abstract List<Dto> GetElem();
    }
    public class DivisionDto: Dto
    {
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public List<EmployeeDto> Employees { get; set; }//

        public override List<Dto> GetElem()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            return Name;
        }
    }
    public class EmployeeDto: Dto
    {
        public string FIO { get; set; }
        public string JobTitle { get; set; }
        public DivisionDto Division { get; set; }

        public override List<Dto> GetElem()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            return FIO;
        }
    }
    public class EquipmentDto: Dto
    {
        public int InventoryNumber { get; set; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public DateTime InstallationDate { get; set; }

        public EmployeeDto ResponsibleEmployee {  get; set; }
        public EquipmentTypeDto Type { get; set; }
        public EquipmentStatus Status { get; set; }
        public MovementHistoryDto story { get; set; }

        public override List<Dto> GetElem()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            return Name;
        }
    }
    public class MovementHistoryDto: Dto
    {
        int insex;
        public MovementHistoryDto(int index)
        {
            this.insex = index;
        }
        public DateTime MoveDate { get; set; }
        public EmployeeDto LastEm {  get; set; }
        public EmployeeDto FirstEm { get; set; }
        public Equipment Equipmen { get; set; }

        public override List<Dto> GetElem()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            if (insex == 0)
            {
                return LastEm.GetName();
            }
            else if (insex == 1)
            {
                return FirstEm.GetName();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
