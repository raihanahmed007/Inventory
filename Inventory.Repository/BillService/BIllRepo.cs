using Inventory.Repository.Paning;
using Inventory.ViewModel.Bills;
using Inventory.ViewModel.Maping;
using Inventory.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillService
{
    public class BillRepo : IBillRepo
    {
        private ApplicationDbContext _context;
        public BillRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<BillListViewModel>> GetAll(int pageNumber, int pageSize)
        {
            var billList = _context.Bills;
            var vm = billList.BillModelToVM().AsQueryable();
            return await PaginatedList<BillListViewModel>.CreateAsync(vm, pageNumber, pageSize);
        }
    }
}
