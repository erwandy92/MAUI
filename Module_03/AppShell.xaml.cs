using Module_03.Pages;

namespace Module_03
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //When any action hits to the name page of ShopDetails, then go to the page whose type is ShopDetails
            Routing.RegisterRoute($"//ShopPage/{nameof(ShopDetails)}", typeof(ShopDetails));
        }
    }
}
