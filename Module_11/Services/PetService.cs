using Module_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11.Services;

public class PetService : IPetService
{
    private readonly List<PetModel> pets = new();
    private void RefreshData()
    {
        pets.Add(new PetModel() { PetId = 101, PetName = "Dog1", PictureUrl = "dog1.jpg", Type = "Dog", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 102, PetName = "Dog2", PictureUrl = "dog2.jpg", Type = "Dog", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 103, PetName = "Dog3", PictureUrl = "dog3.jpg", Type = "Dog", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 201, PetName = "Cat1", PictureUrl = "cat1.jpg", Type = "Cat", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 202, PetName = "Cat2", PictureUrl = "cat2.jpg", Type = "Cat", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 203, PetName = "Cat3", PictureUrl = "cat3.jpg", Type = "Cat", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 204, PetName = "Cat4", PictureUrl = "cat4.jpg", Type = "Cat", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 301, PetName = "Hamster1", PictureUrl = "hamster1.jpg", Type = "Hamster", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 302, PetName = "Hamster2", PictureUrl = "hamster2.jpg", Type = "Hamster", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 303, PetName = "Hamster3", PictureUrl = "hamster3.jpg", Type = "Hamster", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
        pets.Add(new PetModel() { PetId = 401, PetName = "Parrot1", PictureUrl = "parrot.jpg", Type = "Parrot", Owner = "You", AdopDate = new DateTime(2020, 1, 1) });
    }

    public PetService()
    {
        RefreshData();
    }

    public async Task<int> AddPetAsync(PetModel petModel)
    {
        await Task.Delay(100);
        petModel.PetId = pets.Count + 1;
        pets.Add(petModel);
        return 1;
    }

    public async Task<int> DeletePetAsync(PetModel petModel)
    {
        await Task.Delay(100);
        var pet = pets.Where((p) => p.PetId == petModel.PetId).FirstOrDefault();
        int result = 0;
        if (pet != null)
        {
            pets.Remove(pet);
            result = 1;
        }
        return result;
    }

    public async Task<PetModel> GetPetByIdAsync(int id)
    {
        await Task.Delay(50);
        return pets.Find((p) => p.PetId == id);
    }

    public async Task<List<PetModel>> GetPetsAsync()
    {
        await Task.Delay(500);
        return pets;
    }

    public async Task<int> UpdatePetAsync(PetModel petModel)
    {
        await Task.Delay(100);
        var pet = pets.FirstOrDefault((p) => p.PetId == petModel.PetId);
        int result = 0;
        if (pet != null)
        {
            pet = petModel;
            result = 1;
        }
        return result;
    }
}
