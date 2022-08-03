﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMonitoring.Domain.Models
{
    public class User : DomainObject
    {
        public string Username { get; set; }

        public string Password { get; set; }    
    }
}
