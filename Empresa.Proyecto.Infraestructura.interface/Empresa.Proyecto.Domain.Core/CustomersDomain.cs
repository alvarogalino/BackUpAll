using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Proyecto.Domain.Entity;
using Empresa.Proyecto.Domain.Interface;
using Empresa.Proyecto.Infraestructura.Interface;



namespace Empresa.Proyecto.Domain.Core
{
    public class CustomersDomain : ICustomerDomain
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersDomain(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

        }

        public bool Delete(string customersId)
        {
            return _customerRepository.Delete(customersId);
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(string customersId)
        {
            return await _customerRepository.DeleteAsync(customersId);
            throw new NotImplementedException();
        }

        public Customers Get(string customerId)
        {
            return _customerRepository.Get(customerId);
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customerRepository.GetAll();
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
            throw new NotImplementedException();
        }

        public async Task<Customers> GetAsync(string customerId)
        {
            return await _customerRepository.GetAsync(customerId);
            throw new NotImplementedException();
        }

        public bool Insert(Customers customers)
        {
            return _customerRepository.Insert(customers);
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(Customers customers)
        {
            return await _customerRepository.InsertAsync(customers);
            throw new NotImplementedException();
        }

        public bool Update(Customers customers)
        {
            return _customerRepository.Update(customers);
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _customerRepository.UpdateAsync(customers);
            throw new NotImplementedException();
        }
    }

    
    
}
