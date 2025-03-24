using Maui.eCommerce.ViewModels;

namespace Maui.eCommerce.Views;

public partial class CheckOutView : ContentPage
{
	public CheckOutView()
	{
		InitializeComponent();
        BindingContext = new CheckOutViewModel();
    }
    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
}