using ITMonitoring.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMonitoring.EntityFramework
{
    public class ITMonitoringDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Tablet> Tablets { get; set; }

        public ITMonitoringDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
