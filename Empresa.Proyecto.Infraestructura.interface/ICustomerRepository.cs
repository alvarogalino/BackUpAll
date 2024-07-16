using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Proyecto.Domain.Entity;

namespace Empresa.Proyecto.Infraestructura.Interface

{
    public interface ICustomerRepository
    {
        #region Metodos Sincronos
        bool Insert (Customers customers);
        bool Update (Customers customers);
        bool Delete (string customersId);

        Customers Get (string customerId);

        IEnumerable<Customers> GetAll ();

        #endregion

        #region Metodos Asincronos

        Task <bool> InsertAsync(Customers customers);
        Task <bool> UpdateAsync(Customers customers);
        Task <bool> DeleteAsync(string customersId);

        Task <Customers> GetAsync(string customerId);

        Task <IEnumerable<Customers>> GetAllAsync();

        #endregion


    }
}
