using Ecommerce.Models.Models;
using Ecommerce.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecommerce.Models.ViewModels
{
    public class CustomerCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { set; get; }
        public ICollection<CustomerResponseModel> CustomerList { set; get; }
    }
}
