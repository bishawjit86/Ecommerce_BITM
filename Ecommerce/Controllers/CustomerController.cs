using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Bll;
using Ecommerce.BLL.Abstraction;
using Ecommerce.DataBase;
using Ecommerce.Models;
using Ecommerce.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models.ViewModels;
using Ecommerce.Models.ResponseModels;
using AutoMapper;


namespace Ecommerce.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerManager _manager;
        public IMapper _mapper;
        public CustomerController(ICustomerManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            CustomerCreateViewModel customer = new CustomerCreateViewModel();
            customer.CustomerList = _manager.GetAll()
                                            .Select(c =>_mapper.Map<CustomerResponseModel>(c)).ToList();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Create(CustomerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Customer customer = _mapper.Map<Customer>(model);
                bool isSave = _manager.Add(customer);
                if (isSave)
                {
                    ModelState.Clear();
                    return View();
                }
            }
            return View();
        }
        public IActionResult List()
        {
            CustomerCreateViewModel customer = new CustomerCreateViewModel();
            customer.CustomerList = _manager.GetAll()
                                            .Select(c => _mapper.Map<CustomerResponseModel>(c)).ToList();
            return View(customer);


            //ICollection<Customer> customers = _customerManager.GetAll();
           // return View(customers);

        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Customer acustomer = _manager.GetById((int)id);
            if (acustomer != null)
            {
                return View(acustomer);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            bool isUpdated = _manager.Update(customer);
            if (isUpdated)
            {
                return RedirectToAction("List");
            }
            return View(customer);
        }
        //public IActionResult Delete(int? id)
        //{
        //    //bool isSaved = _manager.Deleted((int)id);
        //    //if (isSaved)
        //    //{
        //    //    return RedirectToAction("List");
        //    //}
        //    //return View("Create");
        //}
    }

}
