﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int ClienteID { get; set; }
    }

}
