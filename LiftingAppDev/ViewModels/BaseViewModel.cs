using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LiftingAppDev.ViewModels;

public class BaseViewModel : INotifyPropertyChanged 
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName]string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void ShowErrorPopup(string message)
    {
        Application.Current.MainPage.DisplayAlert("Error", message, "OK");
    }

    public void ShowInfoPopup(string message)
    {
        Application.Current.MainPage.DisplayAlert("Info", message, "OK");
    }

}