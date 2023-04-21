using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Data
{
    public class HRMDbContext :DbContext
    {
        public HRMDbContext(DbContextOptions<HRMDbContext> options):base(options)
        {

        }public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobRequirement> JobRequirements { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<EmployeeRequirementType> EmployeeRequirementTypes { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}