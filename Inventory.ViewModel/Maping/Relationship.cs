using Inventory.Models;
using Inventory.ViewModel.Bills;
using Inventory.ViewModel.Customers;
using Inventory.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Maping
{
    public static class Relationship
    { 
        public static IEnumerable<CustomerTypeListViewModel> ModelToVM(this IEnumerable<CustomersType> customerType)
        {
            List<CustomerTypeListViewModel> list = new List<CustomerTypeListViewModel>();
            foreach (var ct in customerType)
            {
                list.Add(new CustomerTypeListViewModel()
                {
                    CustomerTypeId = ct.CustomerTypeId,
                    CustomerTypeName = ct.CustomerTypeName,
                    Description = ct.Description,
                });
                
            }
            return list;

        }
        public static IEnumerable<CustomerListViewModel>
            CustomerModelToVM(this IEnumerable<Customer> customers)
        {
            List<CustomerListViewModel> list = new List<CustomerListViewModel>();
            foreach (var c in customers)
            {
                list.Add(new CustomerListViewModel()
                {
                   CustomerId = c.CustomerId,
                   CustomerName = c.CustomerName,
                   City = c.City,
                   State = c.State,
                   ContactPerson= c.ContactPerson,
                   CustomerTypeId = c.CustomerTypeId,
                   ZipCode = c.ZipCode,
                   Address = c.Address,
                   Email = c.Email,
                   Phone = c.Phone
                });

            }
            return list;

        }
        public static IEnumerable<BillTypeListViewModel> ModelToVM(this IEnumerable<BillType> billType)
        {
            List<BillTypeListViewModel> list = new List<BillTypeListViewModel>();
            foreach (var bt in billType)
            {
                list.Add(new BillTypeListViewModel()
                {
                   BillTypesId= bt.BillTypesId,
                   BillTypeName = bt.BillTypeName,
                   Description = bt.Description
                });

            }
            return list;

        }
        public static IEnumerable<BillListViewModel> BillModelToVM(this IEnumerable<Bill> bills)
        {
            List<BillListViewModel> list = new List<BillListViewModel>();
            foreach (var b in bills)
            {
                list.Add(new BillListViewModel()
                {
                    BillId = b.BillId,
                    BillName = b.BillName,
                    GoodsReceiveNoteId = b.GoodsReceiveNoteId,
                    VendorDoNumber = b.VendorDoNumber,  
                    VendorInvoiceNumber = b.VendorInvoiceNumber,    
                    BillDate = b.BillDate,
                    BillDueDate = b.BillDueDate,
                    BillTypeId = b.BillTypeId
                });

            }
            return list;
        }
        public static IEnumerable<ProductTypeListViewModel> ModelToVM(this IEnumerable<ProductType> productTypes)
        {
            List<ProductTypeListViewModel> list = new List<ProductTypeListViewModel>();
            foreach (var pt in productTypes)
            {
                list.Add(new ProductTypeListViewModel()
                {
                   ProductTypeId = pt.ProductTypeId,
                   ProductTypeName = pt.ProductTypeName,
                   Description = pt.Description
                });

            }
            return list;
        }
        public static IEnumerable<ProductListViewModel> ModelToVM(this IEnumerable<Product> products)
        {
            List<ProductListViewModel> list = new List<ProductListViewModel>();
            foreach (var p in products)
            {
                list.Add(new ProductListViewModel()
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    ProductCode = p.ProductCode,
                    ProductImage = p.ProductImage,
                    BuyingPrice = p.BuyingPrice,
                    SellingPrice = p.SellingPrice,
                    BarCode = p.BarCode,
                    BranchId = p.BranchId,
                    Description = p.Description,
                    CurrencyId = p.CurrencyId,
                    MeasureUnitId = p.MeasureUnitId
                });
            }
            return list;
        }
    }
}
