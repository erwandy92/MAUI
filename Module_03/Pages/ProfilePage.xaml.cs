namespace Module_03.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
        //labelProfile.Text = Shell.Current.CurrentState.Location.OriginalString;
        labelProfile.Text = "Welcome to SettingPage's Profile";
    }
}