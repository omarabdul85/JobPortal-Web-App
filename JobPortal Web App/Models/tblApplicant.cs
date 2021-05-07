using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal_Web_App.Models
{
    public class tblApplicant
    {
        public int ApplicantId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public string CivilStatus { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public string Degree { get; set; }
        public string ApplicantPhoto { get; set; }
        public string NationalId { get; set; }
    }
}
