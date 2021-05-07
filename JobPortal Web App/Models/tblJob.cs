using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal_Web_App.Models
{
    public class tblJob
    {
        public int JobId { get; set; }
        public int CompanyId { get; set; }
        public string Category { get; set; }
        public string OccupationTitle { get; set; }
        public int Req_No_Employees { get; set; }
        public float Salaries { get; set; }
        public string DurationEmployement { get; set; }
        public string Qualification_WorkExperience { get; set; }
        public string JobDescription { get; set; }
        public string PreferedSex { get; set; }
        public string SectorVacancy { get; set; }
        public string JobStatus { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
