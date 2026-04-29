using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08.Models;

public partial class PetModel: ObservableObject
{
    [ObservableProperty]
    private int petId;
    [ObservableProperty]
    private string petName;
    [ObservableProperty]
    private string type;
    [ObservableProperty]
    private string pictureUrl;
    [ObservableProperty]
    private string owner;
    [ObservableProperty]
    private DateTime adopDate;
    public override string ToString()
    {
        return $"{Owner} 於 {AdopDate:d} 領養了 {PetId} - {PetName} ";
    }
}

