using Module_08.Models;
using System.Windows.Input;

namespace Module_08.ViewModels;

public class PetViewModel : ViewModelBase
{
    private PetModel _pet = new PetModel();
    public PetModel Pet
    {
        get => _pet;
        set
        {
            if (_pet != value)
            {
                _pet = value;
                Title = $"寵物: {_pet.PetName}";
                OnPropertyChanged();
            }
        }
    }

    public ICommand Save { private set; get; }
    public PetViewModel()
    {
        Title = "寵物資訊";
        Save = new Command<String>(
            execute: async (owner) =>
            {
                await Shell.Current.DisplayAlert($"{owner} 寵物 Data", Pet.ToString(), "OK");
                await Shell.Current.GoToAsync("..");
            }, 
            canExecute: (owner) => !string.IsNullOrEmpty(owner)
         );
    }

}
