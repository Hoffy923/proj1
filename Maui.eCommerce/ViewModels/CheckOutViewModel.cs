using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Library.eCommerce.Models;
using Library.eCommerce.Services;


namespace Maui.eCommerce.ViewModels
{
    public class CheckOutViewModel
    {
        private ShoppingCartService _cartSvc = ShoppingCartService.Current;
        public ObservableCollection<ItemViewModel?> ShoppingCart
        {
            get
            {
                return new ObservableCollection<ItemViewModel?>(_cartSvc.CartItems.Where(i => i?.Quantity > 0).Select(m => new ItemViewModel(m)));
            }
        }

        public string TotalDisplay
        {
            get
            {
                return $"Total: {ShoppingCart.Select(item => (item?.Model?.Quantity ?? 0) * (item?.Model?.Product?.Price ?? 0) * 1.07M).Sum():C}";
            }//going through stuff in shopping cart (create temp list) calc the price and sums
        }

    }
}
