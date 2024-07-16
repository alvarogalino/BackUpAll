using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Empresa.Proyecto.Transversal.Common;






namespace Empresa.Proyecto.Infraestructura.data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;
        

        public ConnectionFactory (IConfiguration configuration)
        {
            _configuration = configuration;
            
        }

        
        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;

                sqlConnection.ConnectionString = _configuration.GetConnectionString("NorthwindConnection");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }
}
