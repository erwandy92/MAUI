using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod071.Models;

public class Employee: INotifyPropertyChanged
{
    private int id;
    private string name;
    private DateTime hireDate;
    private decimal salary;

    public int Id
    {
        get => id;
        set
        {
            if (id != value)
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
    }

    public string Name
    {
        get => name;
        set
        {
            if (name != value)
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public DateTime HireDate
    {
        get => hireDate;
        set
        {
            if (hireDate != value)
            {
                hireDate = value;
                OnPropertyChanged(nameof(HireDate));
            }
        }
    }

    public decimal Salary
    {
        get => salary;
        set
        {
            if (salary != value)
            {
                salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

}

