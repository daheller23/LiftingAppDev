using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LiftingAppDev.ViewModels;

public class BaseViewModel : INotifyPropertyChanged 
{
    #region "Private Variables"

    #endregion

    #region "Public Variables"
    public event PropertyChangedEventHandler? PropertyChanged;
    #endregion

    #region "OnPropertyChanged"
    public void OnPropertyChanged([CallerMemberName]string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

    #region "ShowErrorPopup"
    public void ShowErrorPopup(string message)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        Application.Current.MainPage.DisplayAlert("Error", message, "OK");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
    #endregion

    #region "ShowInfoPopup"
    public void ShowInfoPopup(string message)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        Application.Current.MainPage.DisplayAlert("Info", message, "OK");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
    #endregion

    #region "NavigateToPage"
    public async void NavigateToPage(dynamic page)
    {
        try
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            await Application.Current.MainPage.Navigation.PushAsync(page);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        catch(Exception ex)
        {
            ShowErrorPopup(ex.Message);
        }
    }
    #endregion

}