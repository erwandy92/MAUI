namespace Module_03.Pages;

public partial class SettingPage : ContentPage
{
	public SettingPage()
	{
		InitializeComponent();
        labelSetting.Text = Shell.Current.CurrentState.Location.OriginalString;
	}
}