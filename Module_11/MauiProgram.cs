using Microsoft.Extensions.Logging;
using Module_11.Services;
using Module_11.ViewModels;
using Module_11.Views;

namespace Module_11
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

            //builder.Services.AddSingleton<IPetService, PetService>();
            builder.Services.AddSingleton<IPetService, PetServiceFromWeb>();

            builder.Services.AddSingleton<PetListViewModel>();
            builder.Services.AddSingleton<PetListView>();

            builder.Services.AddTransient<PetViewModel>();
            builder.Services.AddTransient<PetView>();

            return builder.Build();
        }
    }
}
