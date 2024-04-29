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
        private int count = 0;
        #endregion

        #region "Public Variables"
        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region "ICommands"
        public ICommand NavigateToCreateNewWorkoutView_Click => new Command(NavigateToCreateNewWorkoutView);
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







    }
}
