using Humanizer;
using Inventory.Models;
using Inventory.Repository;
using Inventory.Repository.BillTypeService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Web.Pages.ABillType
{
    public class IndexModel : PageModel
    {
        private BillTypeRepo _billTypeRepo;

       
        public IndexModel(BillTypeRepo billTypeRepo)
        {
            _billTypeRepo = billTypeRepo;
        }


        [HttpGet]
        public async Task OnGet(int pageSize = 10, int pageNumber = 1)
        {
           await _billTypeRepo.GetAll(pageSize, pageNumber);
            //return Page(bTypes);
        } 
    }
}
