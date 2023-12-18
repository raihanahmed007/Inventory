using Inventory.Repository.Paning;
using Inventory.ViewModel.Bills;
using Inventory.ViewModel.Maping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillTypeService
{
    public class BillTypeRepo : IBillTypeRepo
    {
        private ApplicationDbContext _context;
        public BillTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<BillTypeListViewModel>> GetAll(int pageNumber, int pageSize)
        {
            var billTypeList = _context.BillTypes;
            var vm = billTypeList.ModelToVM().AsQueryable();
            return await PaginatedList<BillTypeListViewModel>.CreateAsync(vm, pageNumber, pageSize);
        }
    }
}
