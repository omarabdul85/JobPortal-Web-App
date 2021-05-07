using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal_Web_App.Models
{
    public class tblCompany
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyContactNo { get; set; }
        public string CompanyStatus { get; set; }
        public string CompanyMission { get; set; }
    }
}
