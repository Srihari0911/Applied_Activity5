using Applied5.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace Applied5.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    List<Student> _Students;

    [RelayCommand]
    void ShowData()
    {

    }
}