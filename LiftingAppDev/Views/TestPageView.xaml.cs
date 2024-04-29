using LiftingAppDev.ViewModels;

namespace LiftingAppDev
{
    public partial class TestPageView : ContentPage
    {
        public TestPageView()
        {
            InitializeComponent();
            this.BindingContext = new TestPageViewModel();
        }

    }

}
