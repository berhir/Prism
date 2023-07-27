using Microsoft.Extensions.Logging;
using Prism.Ioc;
using Prism.Navigation;

namespace PrismFlyoutCanNavigate
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
                })
                .UsePrism(builder =>
                {
                    builder.OnAppStart((containerProvider, navigationService) =>
                        navigationService.CreateBuilder()
                            .AddSegment<MainViewModel>()
                            .AddNavigationPage()
                            .AddSegment<Page1ViewModel>()
                            .NavigateAsync());
                });

#if DEBUG
            //   builder.Logging.AddDebug();
#endif

            builder.Services.RegisterForNavigation<MainPage, MainViewModel>();
            builder.Services.RegisterForNavigation<Page1, Page1ViewModel>();

            return builder.Build();
        }
    }
}
