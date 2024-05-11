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

        #endregion

        public MainPageViewModel()
        {


                      
        }

        #region "NavigateToCreateNewWorkoutView"
        // Function: NavigateToCreateNewWorkoutView(void)
        // Description: Navigates To the CreateNewWorkoutView (currently called TestPageView)
        private void NavigateToCreateNewWorkoutView()
        {
            try
            {
                NavigateToPage(new TestPageView());
            }
            catch(Exception ex)
            {
                ShowErrorPopup($"NavigateToCreateNewWorkoutView: {ex.Message}");
            }

        }
        #endregion



    }
}
