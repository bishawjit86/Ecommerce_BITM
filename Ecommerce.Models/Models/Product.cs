using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Models.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public int? CategoriesId { get; set; }
        public Categories categories { get; set; }


    }
}
