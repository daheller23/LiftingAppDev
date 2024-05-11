using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
#region "Usings"
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
#endregion

namespace LiftingAppDev.ViewModels
{
    public partial class TestPageViewModel : BaseViewModel
    {
        #region "Private Variables"
        private string workoutName = string.Empty;
        private string workoutDescription = string.Empty;

        #endregion

        #region "Public Variables"

        public string WorkoutName
        {
            get => workoutName;
            set
            {
                workoutName = value;
                OnPropertyChanged();
            }
        }

        public string WorkoutDescription
        {
            get => workoutDescription;
            set
            {
                workoutDescription = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region "ICommands"
        public ICommand CreateNewWorkout_Submit_Click => new Command(CreateNewWorkout_Submit);
        #endregion

        public TestPageViewModel()
        {
            
        }

        #region "CreateNewWorkout_Submit"
        // Function: CreateNewWorkout_Submit(void)
        // Description: Creates a new workout entry
        private void CreateNewWorkout_Submit()
        {
            try
            {
                if (string.IsNullOrEmpty(WorkoutName)) { throw new Exception("You must name your workout."); }
                NavigateBack();
            }
            catch (Exception ex) 
            {
                ShowErrorPopup($"CreateNewWorkout_Submit: {ex.Message}");
            }
        }
        #endregion


    }
}
