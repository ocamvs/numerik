using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerik.mod
{
    public class Division
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Supervisor { get; set; }

        public List<Employee> Employees { get; set; }//
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string JobTitle { get; set; }

        public int DivisionId { get; set; }
        public Division Division { get; set; }
    }
    public class Equipment
    {
        public int InventoryNumber { get; set; }
        public int SerialNumber { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public DateTime InstallationDate { get; set; }

        public int ResponsibleEmployeeId { get; set; }
        public int TypeId { get; set; }
        public Employee ResponsibleEmployee {  get; set; }
        public EquipmentTypeDto Type { get; set; }
        public EquipmentStatus Status { get; set; }
    }
    public class MovementHistory
    {
        public int Id { get; set; }
        public DateTime MoveDate { get; set; }

        public int LastEmId { get; set; }
        public int FirstEmId { get; set; }
        public int EquipmenId { get; set; }

        public Employee LastEm {  get; set; }
        public Employee FirstEm { get; set; }
        public Equipment Equipmen { get; set; }
    }
    public class InstalledSoftware
    {
        public int Id { get; set; }
        public DateTime InstallationDates { get; set; }


    }
    public enum EquipmentStatus
    {
        InProgress, 
        Decommissioned, 
        UnderRepair
    }
}
