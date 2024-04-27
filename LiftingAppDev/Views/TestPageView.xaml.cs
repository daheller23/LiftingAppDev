using LiftingAppDev.ViewModels;

namespace LiftingAppDev
{
    public partial class TestPageView : ContentPage
    {
        public TestPageView(TestPageViewModel testPageViewModel)
        {
            InitializeComponent();
            BindingContext = testPageViewModel;
        }

    }

}
