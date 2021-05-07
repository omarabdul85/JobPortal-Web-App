using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal_Web_App.Models
{
    public class tblEmployees
    {
        public int IncId { get; set; }
        public string EmployeeId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string CivilStatus { get; set; }
        public string TelNo { get; set; }
        public string Emp_EmailAddress { get; set; }
        public string CellNo { get; set; }
        public string Position { get; set; }
        public string WorkStats { get; set; }
        public string EmpPhoto { get; set; }
        public string EmpUserName { get; set; }
        public string EmpPassword { get; set; }
        public DateTime DateHired { get; set; }
        public int CompanhyId { get; set; }
    }
}
