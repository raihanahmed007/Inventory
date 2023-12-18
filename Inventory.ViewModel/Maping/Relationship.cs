﻿using Inventory.Models;
using Inventory.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Maping
{
    public static class Relationship
    { 
        public static IEnumerable<CustomerTypeListViewModel> ModelToVM(this IEnumerable<CustomersType> customerType)
        {
            List<CustomerTypeListViewModel> list = new List<CustomerTypeListViewModel>();
            foreach (var ct in customerType)
            {
                list.Add(new CustomerTypeListViewModel()
                {
                    CustomerTypeId = ct.CustomerTypeId,
                    CustomerTypeName = ct.CustomerTypeName,
                    Description = ct.Description,
                });
                
            }
            return list;

        }
    }
}
