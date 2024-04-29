using LiftingAppDev.ViewModels;

namespace LiftingAppDev
{
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }

}
