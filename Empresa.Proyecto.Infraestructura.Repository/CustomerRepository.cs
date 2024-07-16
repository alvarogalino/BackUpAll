using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Proyecto.Domain.Entity;
using Empresa.Proyecto.Infraestructura.Interface;
using Empresa.Proyecto.Transversal.Common;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace Empresa.Proyecto.Infraestructura.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomerRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;

        }

        #region Metodos Sincronicos

        public bool Insert (Customers customers)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomersId", customers.Id); 
                parameters.Add("CustomersPropietario", customers.Propietario);
                parameters.Add("CustomersCiudad", customers.Ciudad);
                parameters.Add("CustomersStock", customers.Stock);
                parameters.Add("CustomersEspecie", customers.Especie);
                parameters.Add("CustomersPresupuesto", customers.Presupuesto);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public bool Update(Customers customers)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomersId", customers.Id);
                parameters.Add("CustomersPropietario", customers.Propietario);
                parameters.Add("CustomersCiudad", customers.Ciudad);
                parameters.Add("CustomersStock", customers.Stock);
                parameters.Add("CustomersEspecie", customers.Especie);
                parameters.Add("CustomersPresupuesto", customers.Presupuesto);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public bool Delete(string customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomersId", customerId);
                
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public Customers Get(string customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetbyId";
                var parameters = new DynamicParameters();
                parameters.Add("CustomersId", customerId);

                var customer = connection.QuerySingle<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;

            }
        }

        public IEnumerable<Customers> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";
                

                var customers = connection.Query<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;

            }
        }




       

        #endregion

        #region Metodos Asincronos

        public async Task<bool> InsertAsync(Customers customers)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomersId", customers.Id);
                parameters.Add("CustomersPropietario", customers.Propietario);
                parameters.Add("CustomersCiudad", customers.Ciudad);
                parameters.Add("CustomersStock", customers.Stock);
                parameters.Add("CustomersEspecie", customers.Especie);
                parameters.Add("CustomersPresupuesto", customers.Presupuesto);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public async Task<bool> UpdateAsync(Customers customers)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomersId", customers.Id);
                parameters.Add("CustomersPropietario", customers.Propietario);
                parameters.Add("CustomersCiudad", customers.Ciudad);
                parameters.Add("CustomersStock", customers.Stock);
                parameters.Add("CustomersEspecie", customers.Especie);
                parameters.Add("CustomersPresupuesto", customers.Presupuesto);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public async Task <bool> DeleteAsync(string customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomersId", customerId);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public async Task <Customers> GetAsync(string customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetbyId";
                var parameters = new DynamicParameters();
                parameters.Add("CustomersId", customerId);

                var customer = await connection.QuerySingleAsync<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;

            }
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";


                var customers = await connection.QueryAsync<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;

            }
        }

        #endregion
    }
}
