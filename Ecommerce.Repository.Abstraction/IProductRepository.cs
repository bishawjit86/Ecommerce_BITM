using Ecommerce.Models.Models;
using Ecommerce.Repository.Abstraction.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Abstraction
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetById(int? id);
    }
}
