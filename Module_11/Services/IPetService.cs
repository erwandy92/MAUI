using Module_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11.Services;

public interface IPetService
{
    Task<List<PetModel>> GetPetsAsync();
    Task<PetModel> GetPetByIdAsync(int id);
    Task<int> AddPetAsync(PetModel petModel);
    Task<int> DeletePetAsync(PetModel petModel);
    Task<int> UpdatePetAsync(PetModel petModel);
}
