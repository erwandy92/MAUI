using Module_09_02.Views;

namespace Module_09_02
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
