#region "Usings"
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit;
#endregion

namespace LiftingAppDev.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        #region "Private Variables"

        #endregion

        #region "Public Variables"

        #endregion

        #region "ICommands"
        public ICommand NavigateToCreateNewWorkoutView_Click => new Command(NavigateToCreateNewWorkoutView);
        public ICommand ErrorPopupWindowTest_Click => new Command(ErrorPopupWindow);
        public ICommand InfoPopupWindowTest_Click => new Command(InfoPopupWindow);
        #endregion

        public MainPageViewModel()
        {


                      
        }


        #region "NavigateToCreateNewWorkoutView"
        private async void NavigateToCreateNewWorkoutView()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TestPageView());
        }
        #endregion

        private void ErrorPopupWindow()
        {
            ShowErrorPopup("An error has occurred.");
        }

        private void InfoPopupWindow()
        {
            ShowInfoPopup("Some info is now being displayed.");
        }


    }
}
