using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Data
{
    public class EmployeeDetailsDbContext : DbContext
    {
        public EmployeeDetailsDbContext(DbContextOptions<EmployeeDetailsDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Employee> Applicants { get; set; }
        
    }
}

