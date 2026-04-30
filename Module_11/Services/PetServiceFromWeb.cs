using Module_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Module_11.Services;

public class PetServiceFromWeb : IPetService
{
    static readonly string baseURL =
        DeviceInfo.Platform == DevicePlatform.Android ?
        "http://10.0.2.2/un498api/pets/" : "http://localhost/un498api/pets/";
    static readonly HttpClient httpClient;

    static PetServiceFromWeb()
    {
        httpClient = new();

        httpClient.BaseAddress = new Uri(baseURL);
        httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

        Connectivity.ConnectivityChanged += (s, e) => IsInternet();
    }

    private static bool IsInternet()
    {
        var isInternet = Connectivity.Current.NetworkAccess == NetworkAccess.Internet;
        if (!isInternet)
        {
            AppShell.Current.DisplayAlert("Error", "目前網路無法連上 Internet ", "OK");
        }
        return isInternet;
    }


    public Task<int> AddPetAsync(PetModel petModel)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeletePetAsync(PetModel petModel)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PetModel>> GetPetsAsync()
    {
        List<PetModel> result = new();
        if (!IsInternet())
            return result;
        try
        {
            result = await httpClient.GetFromJsonAsync<List<PetModel>>("");
        }
        catch (Exception ex)
        {
            await AppShell.Current.DisplayAlert("Error", $"{ex.Message}", "OK");
        }
        return result;
    }
    public async Task<PetModel> GetPetByIdAsync(int id)
    {
        if (!IsInternet()) return null;

        PetModel result = null;

        var response = await httpClient.GetAsync(id.ToString());

        if (response.IsSuccessStatusCode)
            result = await response.Content.ReadFromJsonAsync<PetModel>();
        else
            await AppShell.Current.DisplayAlert("Error:", $"{response.StatusCode}", "OK");
        return result;
    }


    public Task<int> UpdatePetAsync(PetModel petModel)
    {
        throw new NotImplementedException();
    }
}
