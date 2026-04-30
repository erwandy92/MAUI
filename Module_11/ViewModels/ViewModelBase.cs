using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_11.ViewModels;

public partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    private string title;

}
