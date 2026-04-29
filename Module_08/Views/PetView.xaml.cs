using Module_08.ViewModels;

namespace Module_08.Views;

public partial class PetView : ContentPage
{
	private PetViewModel petViewModel;
	public PetView()
	{
		InitializeComponent();
		petViewModel = new PetViewModel();
		this.BindingContext = petViewModel;
	}
}