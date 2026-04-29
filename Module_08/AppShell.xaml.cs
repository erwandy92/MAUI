using Module_08.Views;

namespace Module_08
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PetView), typeof(PetView));
        }
    }
}
