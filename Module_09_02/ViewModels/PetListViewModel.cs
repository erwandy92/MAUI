using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Module_09_02.Models;
using Module_09_02.Services;
using Module_09_02.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09_02.ViewModels;

public partial class PetListViewModel: ViewModelBase
{
    public ObservableCollection<PetModel> PetList { get; } = new();

    [ObservableProperty]
    private bool isRefreshing;

    private readonly IPetService petsService;

    public PetListViewModel(IPetService petsService)
    {
        this.Title = "My Pet List";
        this.petsService = petsService;
        this.isRefreshing = true;
    }

    [RelayCommand]
    public async Task Add()
    {
        await AppShell.Current.GoToAsync(nameof(PetView));
    }

    [RelayCommand]
    public async Task GetPetsAsync()
    {
        var list = await petsService.GetPetsAsync();
        PetList.Clear();
        foreach(var item in list)
        {
            PetList.Add(item);
        }
        IsRefreshing = false;
    }

    [RelayCommand]
    public async Task Edit(PetModel pet)
    {
        var param = new Dictionary<string, object>();
        param.Add("query1", pet);
        await AppShell.Current.GoToAsync(nameof(PetView), param);
    }

    [RelayCommand]
    public async Task Delete(PetModel pet)
    {
        IsRefreshing = true;
        var alert = await AppShell.Current.DisplayAlert("Delete: ", $"Are you sure to delete {pet}?", "Confirm", "Cancel");
        if (alert)
        {
            var result = await petsService.DeletePetAsync(pet);
            if(result > 0)
            {
                await this.GetPetsAsync();
            }
        }
        IsRefreshing = false;
    }

}
