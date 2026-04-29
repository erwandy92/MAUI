using Microsoft.Extensions.Logging;
using Module_09.ViewModels;
using Module_09.Views;

namespace Module_09
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            //Added DI Singleton - ViewModel and View
            builder.Services.AddSingleton<TimeViewModel>();
            builder.Services.AddSingleton<TimeView>();

            return builder.Build();
        }
    }
}
