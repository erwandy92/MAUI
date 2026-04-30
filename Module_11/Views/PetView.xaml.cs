using Module_11.ViewModels;
using System.Threading.Tasks;

namespace Module_11.Views;

public partial class PetView : ContentPage
{
	private PetViewModel petViewModel;
    public PetView(PetViewModel petViewModel)
	{
		InitializeComponent();
		this.petViewModel = petViewModel;
        BindingContext = petViewModel;
	}

 //   private async void SaveButton_Clicked(object sender, EventArgs e)
	//{
	//	await Shell.Current.DisplayAlert("¶s¿…", _viewModel.Pet.ToString(), "OK");

 //   }
}