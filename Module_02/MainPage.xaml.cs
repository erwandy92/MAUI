namespace Module_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_GetOSVersion(object sender, EventArgs e)
        {
            lblOSVersion.Text = $"Platform: {DeviceInfo.Current.Platform}, Version: {DeviceInfo.Current.VersionString}";
        }
    }
}
