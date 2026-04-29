using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Module_09_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module_09_02.ViewModels;

public partial class PetViewModel : ViewModelBase
{
    [ObservableProperty]
    private PetModel pet = new PetModel();
   

    public PetViewModel()
    {
        Title = "寵物";
      
    }

    [RelayCommand(CanExecute = nameof(CanSave))]
    public async void Save(string owner)
    {
        await Shell.Current.DisplayAlert($"{owner}的寵物存檔", Pet.ToString(), "OK");
        await Shell.Current.GoToAsync("..");
    }
    private bool CanSave(string owner)
    {
        return !string.IsNullOrEmpty(owner);
    }



}
