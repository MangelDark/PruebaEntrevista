using Domain.Layer.Models;
using Persistence.Layer.RepositoryPatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Layer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> _repository;

        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return _repository.GetById(id);
        }

        public void InsertCustomer(Customer customer)
        {
            _repository.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
        }
        public void DeleteCustomer(int id)
        {
            Customer customer = _repository.GetById(id);
            _repository.Remove(customer);
            _repository.SaveChanges();
        }

    }
}
