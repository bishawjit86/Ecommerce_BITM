using Ecommerce.DataBase;
using Ecommerce.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ecommerce.Repository.Abstraction;
using Ecommerce.Repository.Abstraction.Base;
using Ecommerce.Models.RequestModels;

namespace Ecommerce.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        EcommerceDbContext db;
        public CustomerRepository(DbContext dbContext) : base(dbContext)
        {
            db = (EcommerceDbContext)dbContext;
        }

        public override ICollection<Customer> GetAll()
        {
            return db.Customers.Where(c => c.IsDeleted == false).ToList();
        }

        public Customer GetById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return GetFirstOrDefault(c => c.Id == id);
        }

        public ICollection<Customer> GetByRequest(CustomerRequestModel customer)
        {
            var result = db.Customers.AsQueryable();
            if (customer != null)
            {
                return result.ToList();
            }
            if (customer.Id > 0)
            {
                result = result.Where(c => c.Id == customer.Id);
            }
            if (!string.IsNullOrEmpty(customer.Name))
            {
                result = result.Where(c => c.Name.ToLower().Contains(customer.Name.ToLower()));
            }
            if (customer.IsDeleted != null)
            {
                result = result.Where(c => c.IsDeleted == customer.IsDeleted);
            }
            if (!string.IsNullOrEmpty(customer.Phone))
            {
                result = result.Where(c => c.Phone == customer.Phone);
            }
            return result.ToList();
        }
    }
}
