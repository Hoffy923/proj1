using Maui.eCommerce.ViewModels;

namespace Maui.eCommerce
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(); //class dictated  by binding context
        }

        private void InventoryClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Inventory Managment"); //current means singleton
        }
    }

}
