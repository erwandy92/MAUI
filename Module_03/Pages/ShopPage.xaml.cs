namespace Module_03.Pages;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();
        labelShop.Text = Shell.Current.CurrentState.Location.OriginalString;
    }
}