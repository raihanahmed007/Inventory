using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        [Required]
        [Display(Name = "Payment Type Name")]
        public string PaymentTypeName { get; set; }
        public string Descrioption { get; set; }
    }
}
