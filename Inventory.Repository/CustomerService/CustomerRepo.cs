using Inventory.Repository.Paning;
using Inventory.ViewModel.Customers;
using Inventory.ViewModel.Maping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.CustomerService
{
    public class CustomerRepo : ICustomerRepo
    {
        private ApplicationDbContext _context;
        public CustomerRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<CustomerListViewModel>> GetAll(int pageNumber, int pageSize)
        {

            var customerList = _context.Customers;
            var vm = customerList.CustomerModelToVM().AsQueryable();
            return await PaginatedList<CustomerListViewModel>.CreateAsync(vm, pageNumber, pageSize);
        }
       
    }
}
