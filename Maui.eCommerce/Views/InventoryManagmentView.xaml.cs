using Library.eCommerce.Services;
using Maui.eCommerce.ViewModels;

namespace Maui.eCommerce.Views;

public partial class InventoryManagmentView : ContentPage
{
	public InventoryManagmentView()
	{
		InitializeComponent();
		BindingContext = new InventoryManagmentViewModel();//bindingcontext is a property on ContentPage
	}

    private void DeleteClicked(object sender, EventArgs e)
    {
		(BindingContext as InventoryManagmentViewModel)?.Delete();
    }
    private void CancleClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//MainPage");
	}
    
}
