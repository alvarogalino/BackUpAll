using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Proyecto.Aplicacion.DTO;
using Empresa.Proyecto.Transversal.Common;

namespace Empresa.Proyecto.Aplicacion.Interface
{
    public interface ICustomersAplication
    {
        #region Metodos Sincronos
        Response <bool> Insert(CustomersDTO customersDto);
        Response <bool> Update(CustomersDTO customersDto);
        Response <bool> Delete(string customersDto);

        Response <CustomersDTO> Get(string customerDto);

        Response <IEnumerable<CustomersDTO>> GetAll();

        #endregion

        #region Metodos Asincronos

        Task <Response<bool>> InsertAsync(CustomersDTO customersDto);
        Task<Response<bool>> UpdateAsync(CustomersDTO customersDto);
        Task<Response<bool>> DeleteAsync(string customersDto);

        Task<Response<CustomersDTO>> GetAsync(string customerDto);

        Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync();

        #endregion
    }
}
