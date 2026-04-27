namespace Module_03.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
        labelProfile.Text = Shell.Current.CurrentState.Location.OriginalString;
    }
}