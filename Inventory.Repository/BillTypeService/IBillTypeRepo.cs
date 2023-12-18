using Inventory.Repository.Paning;
using Inventory.ViewModel.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillTypeService
{
    public interface IBillTypeRepo
    {
        Task<PaginatedList<BillTypeListViewModel>> GetAll(int pageNumber, int pageSize);
    }
}
