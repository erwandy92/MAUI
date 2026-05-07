using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Module_08.Models;
using System.Windows.Input;

namespace Module_08.ViewModels;

public partial class PetViewModel : ViewModelBase
{
    [ObservableProperty]
    private PetModel pet = new();

    public PetViewModel()
    {
        Title = "寵物資訊";
    }

    [RelayCommand(CanExecute = nameof(CanSave))]
    public async void Save(string owner)
    {
        await Shell.Current.DisplayAlert($"{owner} 寵物 Data", Pet.ToString(), "OK");
        await Shell.Current.GoToAsync("..");
    }
    private bool CanSave(string owner)
    {
        return !string.IsNullOrEmpty(owner);
    }

}
