using Ecommerce.DataBase;
using Ecommerce.Models.Models;
using Ecommerce.Repository.Abstraction;
using Ecommerce.Repository.Abstraction.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        EcommerceDbContext db;
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
            db = (EcommerceDbContext)dbContext;
        }

        public Product GetById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
