﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectENTITIES.Models
{
    public class Shipper:BaseEntity
    {
        public string CompanyName { get; set; }

        //Relational Properties
        public virtual List<Order> Orders { get; set; }
    }
}
