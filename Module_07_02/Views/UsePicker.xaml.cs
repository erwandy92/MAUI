using System.Collections.ObjectModel;

namespace Module_07_02.Views;

public partial class UsePicker : ContentPage
{
    //List<String> petType = new List<String>();
    ObservableCollection<String> petType;

    public UsePicker()
    {
        InitializeComponent();
        //petType.AddRange(new String[] { "Dog", "Cat", "Mouse", "Bird" });
        petType = new () { "Dog", "Cat", "Mouse", "Bird" };
        picker.ItemsSource = petType;
    }

    private void addButton_Clicked(object sender, EventArgs e) =>
        petType.Add("Penguin");

    private void removeButton_Clicked(object sender, EventArgs e) =>
        petType.Remove(picker.SelectedItem.ToString());
}