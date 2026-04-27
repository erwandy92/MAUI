namespace Module_03.Pages;

public partial class SettingPage : ContentPage
{
	public SettingPage()
	{
		InitializeComponent();
		label1.Text = Shell.Current.CurrentState.Location.OriginalString;
	}
}