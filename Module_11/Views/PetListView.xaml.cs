using Module_11.ViewModels;

namespace Module_11.Views;

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