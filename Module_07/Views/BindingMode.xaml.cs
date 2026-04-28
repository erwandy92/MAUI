namespace Module_07.Views;

public partial class BindingMode : ContentPage
{
    public BindingMode()
    {
        InitializeComponent();

        srcEntry.Text = "Hello World";

        //Default as Two-Way binding
        tgEntry.SetBinding(Entry.TextProperty, static (Entry e) => e.Text, source: srcEntry);

        // Use Microsoft.Maui.Controls.BindingMode.OneTime instead of BindingMode.OneTime
        tgOneTime.SetBinding(Entry.TextProperty, static (Entry e) => e.Text, mode: Microsoft.Maui.Controls.BindingMode.OneTime, source: srcEntry);
    }
}