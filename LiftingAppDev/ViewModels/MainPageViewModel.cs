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
    public partial class MainPageViewModel : ContentPage
    {
        #region "Private Variables"
        private int count = 0;
        #endregion

        #region "ICommands"
        public ICommand ButtonClicked { get; set; }
        #endregion

        public MainPageViewModel()
        {
            ButtonClicked = new Command(() =>
            {
                OnCounterClicked();
            });

                      
        }

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

        #region "OnCounterClicked"
        private void OnCounterClicked()
        {
            Count++;
        }
        #endregion







    }
}
