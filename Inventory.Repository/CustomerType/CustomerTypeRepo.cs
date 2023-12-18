﻿using DocumentFormat.OpenXml.Wordprocessing;
using Inventory.Repository.Paning;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Maping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.CustomerType
{
    public class CustomerTypeRepo : ICustomerTypeRepo
    {
        private ApplicationDbContext _context;
        public CustomerTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<CustomerTypeListViewModel>> GetAll()
        {

            var customerTypeList = _context.CustomerTypes;
            var vm = customerTypeList.ModelToVM().AsQueryable();
            return await PaginatedList<CustomerTypeListViewModel>.CreateAsync(vm,pageNumber, pageSize);
        }
    }
}