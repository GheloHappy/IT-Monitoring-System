using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMonitoring.EntityFramework
{
    public class ITMonitoringDbContextFactory : IDesignTimeDbContextFactory<ITMonitoringDbContext>
    {
        public ITMonitoringDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<ITMonitoringDbContext>();
            options.UseSqlServer("Server=mdiserver-l;Database=IT_Monitoring;user id=sa;Password=Passw0rd;");

            return new ITMonitoringDbContext(options.Options);
        }
    }
}
