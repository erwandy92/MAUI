using Module_09.Views;

namespace Module_09
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            AppShell.Current.GoToAsync(nameof(TimeView));
        }
    }
}
