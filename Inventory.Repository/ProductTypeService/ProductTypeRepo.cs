using Inventory.Repository.Paning;
using Inventory.ViewModel.Maping;
using Inventory.ViewModel.Bills;
using Inventory.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.ProductTypeService
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        private ApplicationDbContext _context;
        public ProductTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<ProductTypeListViewModel>> GetAll(int pageNumber, int pageSize)
        {
            var productTypeList = _context.ProductTypes;
            var vm = productTypeList.ModelToVM().AsQueryable();
            return await PaginatedList<ProductTypeListViewModel>.CreateAsync(vm, pageNumber, pageSize); 
        }
    }
}
