using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Bills
{
    public class BillTypeListViewModel
    {

        public int BillTypesId { get; set; }
        [Required]
        [Display(Name ="Bill Name")]
        public string BillTypeName { get; set; }
        [Display(Name = "Bill Description")]
        public string Description { get; set; }
    }
}
