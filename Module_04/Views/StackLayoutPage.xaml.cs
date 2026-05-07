namespace Module_04.Views;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
	}

    private void btnChangeLayout_Clicked(object sender, EventArgs e)
    {
        stack1.Orientation = StackOrientation.Vertical;
        lblPizza.HorizontalOptions = LayoutOptions.Start;
        lblSushi.HorizontalOptions = LayoutOptions.End;
        lblBurger.HorizontalOptions = LayoutOptions.Center;
        lblPasta.HorizontalOptions = LayoutOptions.Fill;
    }
}