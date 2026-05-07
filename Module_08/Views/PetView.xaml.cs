using Module_08.ViewModels;

namespace Module_08.Views;

public partial class PetView : ContentPage
{
	private readonly PetViewModel petViewModel = new();
	public PetView()
	{
		InitializeComponent();
		BindingContext = petViewModel;
	}

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.DisplayAlert("¶s¿…", petViewModel.Pet.ToString(), "OK");

    }
}