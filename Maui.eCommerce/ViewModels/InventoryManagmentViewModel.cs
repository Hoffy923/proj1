using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.eCommerce.Services;
using proj1.Models;

namespace Maui.eCommerce.ViewModels
{
    public class InventoryManagmentViewModel
    {
        public Product? SelectedProduct { get; set; }
        private ProductServiceProxy _svc = ProductServiceProxy.Current; //most things are passed by refernce
        public List<Product?> Products
        {
            get
            {
                return _svc.Products;
            }
        }
        public Product? Delete()
        {
            return _svc.Delete(SelectedProduct?.Id ?? 0);
        }
    }
}
