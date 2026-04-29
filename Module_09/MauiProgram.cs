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
            //Scenario 1 - The data and view will persist when it's being recalled
            builder.Services.AddSingleton<TimeViewModel>(); //ViewModel (Data Handling part)
            builder.Services.AddSingleton<TimeView>(); //View

            //Scenario 2 - The data and view will be recreated when it's being recalled
            //builder.Services.AddTransient<TimeViewModel>();
            //builder.Services.AddTransient<TimeView>();

            //Scenario 3 - The data will persist, but the view will be recreated when it's being recalled
            //builder.Services.AddSingleton<TimeViewModel>();
            //builder.Services.AddTransient<TimeView>();

            //Scenario 4 - The data and view will persist when it's being recalled (due to the View keeps showing the same one upon Singleton)
            //builder.Services.AddTransient<TimeViewModel>();
            //builder.Services.AddSingleton<TimeView>();

            return builder.Build();
        }
    }
}
