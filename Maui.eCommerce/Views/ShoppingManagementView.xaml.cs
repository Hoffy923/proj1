using Maui.eCommerce.ViewModels;

namespace Maui.eCommerce.Views;

public partial class ShoppingManagementView : ContentPage
{
	public ShoppingManagementView()
	{
		InitializeComponent();
		BindingContext = new ShoppingManagementViewModel();
	}
	private void AddToCartClicked(object sender, EventArgs e)
	{
		(BindingContext as ShoppingManagementViewModel).PurchaseItem();
	}
	private void RemoveFromCartClicked(object sender, EventArgs e)
	{
        (BindingContext as ShoppingManagementViewModel)?.ReturnItem();
    }
    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as ShoppingManagementViewModel)?.RefreshProductList();
    }
	
	private void InLineAddClicked(object sender, EventArgs e)
	{
		(BindingContext as ShoppingManagementViewModel)?.RefreshUX();

    }
}
