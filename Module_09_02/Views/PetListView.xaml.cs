using Module_09_02.ViewModels;

namespace Module_09_02.Views;

public partial class PetListView : ContentPage
{
	PetListViewModel viewModel;
	public PetListView(PetListViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		this.BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		viewModel.GetPetsCommand.Execute(null);
    }
}