namespace Module_07_02.Views;

public partial class UsePicker : ContentPage
{
    List<String> petType = new List<String>();
    public UsePicker()
    {
        InitializeComponent();
        petType.AddRange(new String[] { "Dog", "Cat", "Mouse", "Bird" });
        picker.ItemsSource = petType;
    }

}