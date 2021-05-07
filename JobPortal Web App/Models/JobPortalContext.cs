using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortal_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_Web_App.Models
{
    public class JobPortalContext : DbContext
    {
        public JobPortalContext(DbContextOptions<JobPortalContext> options) : base(options)
        {
        }

        public DbSet<tblApplicant> Candidatos { get; set; }
        public DbSet<tblCategory> Categorias { get; set; }
        public DbSet<tblCompany> Empresas { get; set; }
        public DbSet<tblEmployees> Estudantes { get; set; }
        public DbSet<tblJob> Vagas { get; set; }
    }
}
