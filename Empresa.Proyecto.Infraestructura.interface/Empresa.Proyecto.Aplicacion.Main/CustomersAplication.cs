using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Empresa.Proyecto.Aplicacion.DTO;
using Empresa.Proyecto.Aplicacion.Interface;
using Empresa.Proyecto.Domain.Entity;
using Empresa.Proyecto.Domain.Interface;
using Empresa.Proyecto.Transversal.Common;


namespace Empresa.Proyecto.Aplicacion.Main
{
    public class CustomersAplication : ICustomersAplication
    {
        private readonly ICustomerDomain _customerDomain;
        private readonly IMapper _mapper;


        public CustomersAplication(ICustomerDomain customerDomain, IMapper mapper)
        {
            _customerDomain = customerDomain;
            _mapper = mapper;
        }

        #region Metodos Sincronos

        public Response<bool> Insert(CustomersDTO customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = _customerDomain.Insert(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;

        }
        public Response<bool> Update(CustomersDTO customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = _customerDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }
        public Response<bool> Delete(string customersDto)
        {
            var response = new Response<bool>();
            try
            {

                response.Data = _customerDomain.Delete(customersDto);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Elimoinacion Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public Response<CustomersDTO> Get(string customerId)
        {
            var response = new Response<CustomersDTO>();
            try
            {
                var customer = _customerDomain.Get(customerId);
                response.Data = _mapper.Map<CustomersDTO>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public Response<IEnumerable<CustomersDTO>> GetAll()
        {
            var response = new Response<IEnumerable<CustomersDTO>>();
            try
            {
                var customers = _customerDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomersDTO>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }


        #endregion



        #region Metodos Asincronos

        public async Task<Response<bool>> InsertAsync(CustomersDTO customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = await _customerDomain.InsertAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }
        public async Task<Response<bool>> UpdateAsync(CustomersDTO customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = await _customerDomain.UpdateAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }
        public async Task<Response<bool>> DeleteAsync(string customersDto)
        {
            var response = new Response<bool>();
            try
            {

                response.Data = await _customerDomain.DeleteAsync(customersDto);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Elimoinacion Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public async Task<Response<CustomersDTO>> GetAsync(string customerId)
        {
            var response = new Response<CustomersDTO>();
            try
            {
                var customer = await _customerDomain.GetAsync(customerId);
                response.Data = _mapper.Map<CustomersDTO>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public async Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomersDTO>>();
            try
            {
                var customers = await _customerDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomersDTO>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        #endregion

    }  
}
