using Module_08.Views;
using System.Threading.Tasks;

namespace Module_08
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoPageViewClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PetView));
        }
    }
}
