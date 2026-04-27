namespace Module_03.Pages;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();
        labelShop.Text = Shell.Current.CurrentState.Location.OriginalString;
    }

    private async void Detail_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync(nameof(ShopDetails));
        }
        catch (Exception ex)
        {
            await DisplayAlert("¿ù»~", ex.Message, "½T©w");
        }
    }
}