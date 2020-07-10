using Ecommerce.BLL.Abstraction;
using Ecommerce.BLL.Abstraction.Base;
using Ecommerce.Models.Models;
using Ecommerce.Models.RequestModels;
using Ecommerce.Repository;
using Ecommerce.Repository.Abstraction;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.Bll
{
    public class CustomerManager : Manager<Customer>, ICustomerManager
    {
        private ICustomerRepository _repository;
        public CustomerManager(ICustomerRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Customer GetById(int? id)
        {
            if (id != null)
            {
                return _repository.GetById(id);
            }
            return null;
        }
        public ICollection<Customer> GetByRequest(CustomerRequestModel customer)
        {
            return _repository.GetByRequest(customer);
        }


    }
}
