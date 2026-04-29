using Module_08.Models;

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
                OnPropertyChanged();
            }
        }
    }

    public PetViewModel()
    {
        Title = "寵物資訊";
    }

}
