using Mod071.Models;

namespace Module_07.Views;

public partial class SourceFromModel : ContentPage
{
    public Employee employee;
    public SourceFromModel()
	{
		InitializeComponent();
        this.employee = new Employee
        {
            Id = 1,
            Name = "John Doe",
            HireDate = new DateTime(2020, 1, 15),
            Salary = 50000m
        };
        this.BindingContext = this.employee;
    }

    private void showButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Show", $$"""
                                ID:{{employee.Id}}
                                Name:{{employee.Name}}
                                HireDate: {{employee.HireDate:d}}
                                Salary:{{employee.Salary:c}}
                                """
                           , "OK");

    }

    private void refreshButton_Clicked(object sender, EventArgs e)
    {
        this.employee.Name = "Anita";
        this.employee.Salary = 35000;
    }
}