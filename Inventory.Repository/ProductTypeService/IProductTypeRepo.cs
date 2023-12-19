using Inventory.Repository.Paning;
using Inventory.ViewModel.Bills;
using Inventory.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.ProductTypeService
{
    public interface IProductTypeRepo
    {
        Task<PaginatedList<ProductTypeListViewModel>> GetAll(int pageNumber, int pageSize);
    }
}

