﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Proyecto.Domain.Entity
{
    public class Customers
    {
        public int Id { get; set; }
        public string Especie { get; set; }

        public string Ciudad { get; set; }

        public string Propietario { get; set;}

        public string Stock { get; set;}

        public string Presupuesto { get; set;}
    }
}
