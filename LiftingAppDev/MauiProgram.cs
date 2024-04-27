using LiftingAppDev.ViewModels;
using Microsoft.Extensions.Logging;

namespace LiftingAppDev
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPageView>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<TestPageView>();
            builder.Services.AddSingleton<TestPageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
