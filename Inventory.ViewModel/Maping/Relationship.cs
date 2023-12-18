using Inventory.Models;
using Inventory.ViewModel.Customers;
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
        public static IEnumerable<CustomerListViewModel>
            CustomerModelToVM(this IEnumerable<Customer> customers)
        {
            List<CustomerListViewModel> list = new List<CustomerListViewModel>();
            foreach (var c in customers)
            {
                list.Add(new CustomerListViewModel()
                {
                   CustomerId = c.CustomerId,
                   CustomerName = c.CustomerName,
                   City = c.City,
                   State = c.State,
                   ContactPerson= c.ContactPerson,
                   CustomerTypeId = c.CustomerTypeId,
                   ZipCode = c.ZipCode,
                   Address = c.Address,
                   Email = c.Email,
                   Phone = c.Phone
                });

            }
            return list;

        }
    }
}
