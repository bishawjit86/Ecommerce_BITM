using Ecommerce.Models.Models;
using Ecommerce.Models.RequestModels;
using Ecommerce.Repository.Abstraction.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Abstraction
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetById(int? id);
        ICollection<Customer> GetByRequest(CustomerRequestModel customer);
    }
}
