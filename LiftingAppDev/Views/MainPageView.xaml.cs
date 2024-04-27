using LiftingAppDev.ViewModels;

namespace LiftingAppDev
{
    public partial class MainPageView : ContentPage
    {
        public MainPageView(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }
    }

}
