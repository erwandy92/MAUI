using Module_09.Views;

namespace Module_09
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TimeView), typeof(TimeView));
        }
    }
}
