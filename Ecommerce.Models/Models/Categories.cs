using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
