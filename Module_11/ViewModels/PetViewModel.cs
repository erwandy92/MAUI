using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Module_11.Models;
using Module_11.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module_11.ViewModels;

[QueryProperty(nameof(Pet), "query1")]
public partial class PetViewModel : ViewModelBase
{
    [ObservableProperty]
    private PetModel pet = new();

    private readonly IPetService petsService;
    public PetViewModel(IPetService petsService)
    {
        this.petsService = petsService;
        Title = "寵物";
      
    }

    [RelayCommand(CanExecute = nameof(CanSave))]
    //public async void Save(string owner)
    //{
    //    await Shell.Current.DisplayAlert($"{owner}的寵物存檔", Pet.ToString(), "OK");
    //    await Shell.Current.GoToAsync("..");
    //}
    public async void Save(string owner)
    {
        if(Pet.PetId == 0)
        {
            await petsService.AddPetAsync(Pet);
            await Shell.Current.DisplayAlert($"Added {owner}的寵物存檔", Pet.ToString(), "OK");
        }
        else
        {
            await petsService.UpdatePetAsync(Pet);
            await Shell.Current.DisplayAlert($"Edited {owner}的寵物存檔", Pet.ToString(), "OK");
        }
        await Shell.Current.GoToAsync("..");
    }
    private bool CanSave(string owner)
    {
        return !string.IsNullOrEmpty(owner);
    }



}
