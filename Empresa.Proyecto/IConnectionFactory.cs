﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Proyecto.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
      
    }
}
