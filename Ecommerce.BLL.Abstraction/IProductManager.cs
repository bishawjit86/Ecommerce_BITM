using Ecommerce.BLL.Abstraction.Base;
using Ecommerce.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstraction
{
    public interface IProductManager : IManager<Product>
    {
        Product GetById(int? id);
    }
}
