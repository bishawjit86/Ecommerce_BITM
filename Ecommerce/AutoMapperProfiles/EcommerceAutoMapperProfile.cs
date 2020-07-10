using AutoMapper;
using Ecommerce.Models.Models;
using Ecommerce.Models.ResponseModels;
using Ecommerce.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.AutoMapperProfiles
{
    public class EcommerceAutoMapperProfile : Profile
    {
        public EcommerceAutoMapperProfile()
        {
            CreateMap<CustomerCreateViewModel, Customer>();
            CreateMap<Customer, CustomerCreateViewModel>();
            CreateMap<Customer, CustomerResponseModel>();

        }


    }
}
