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
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    public void ShowErrorPopup(string message)
    {
        Application.Current.MainPage.DisplayAlert("Error", message, "OK");
    }
    #endregion

    #region "ShowInfoPopup"
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    public void ShowInfoPopup(string message)
    {
        Application.Current.MainPage.DisplayAlert("Info", message, "OK");
    }
    #endregion

    #region "NavigateToPage"
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    public async void NavigateToPage(dynamic page)
    {
        try
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
        catch(Exception ex)
        {
            ShowErrorPopup(ex.Message);
        }
    }
    #endregion

    #region "NavigateBack"
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    public async void NavigateBack()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }
    #endregion
}