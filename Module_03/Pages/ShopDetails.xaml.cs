using System.Threading.Tasks;

namespace Module_03.Pages;

public partial class ShopDetails : ContentPage
{
	public ShopDetails()
	{
		InitializeComponent();
		labelShopDetail.Text = Shell.Current.CurrentState.Location.OriginalString + "/" + nameof(ShopDetails);
	}

    private async void Back_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}