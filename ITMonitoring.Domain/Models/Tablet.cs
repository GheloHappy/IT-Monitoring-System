using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMonitoring.Domain.Models
{
    public class Tablet : DomainObject
    {
        public string Series { get; set; }
        public string Transaction { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public DateTime DatePurchased { get; set; }
        public DateTime DateReceived { get; set; }
        public string Others { get; set; }
        public string Remarks { get; set; }
        public double Price { get; set; }

    }
}
