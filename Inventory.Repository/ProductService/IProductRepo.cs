using Inventory.Repository.Paning;
using Inventory.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.ProductService
{
    public interface IProductRepo
    {
        Task<PaginatedList<ProductListViewModel>> GetAll(int pageNumber, int pageSize);
    }
}
