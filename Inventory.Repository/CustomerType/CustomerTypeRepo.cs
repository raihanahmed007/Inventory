using Inventory.Repository.Paning;
using Inventory.ViewModel.Customer;
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
        public Task<PaginatedList<CustomerTypeListViewModel>> GetAll(int pageSize, int pageNumber)
        {
            var customerTypeList = _context.CustomersType;
            var vm = customerTypeList.ModelToVm().AsQuerable();
        }
    }
}
