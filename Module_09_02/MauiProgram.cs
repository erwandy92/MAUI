using Microsoft.Extensions.Logging;
using Module_09_02.Services;
using Module_09_02.ViewModels;
using Module_09_02.Views;

namespace Module_09_02
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

            builder.Services.AddSingleton<IPetService, PetService>();

            builder.Services.AddSingleton<PetListViewModel>();
            builder.Services.AddSingleton<PetListView>();

            builder.Services.AddTransient<PetViewModel>();
            builder.Services.AddTransient<PetView>();

            return builder.Build();
        }
    }
}
