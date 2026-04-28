using Microsoft.Extensions.Logging;

namespace Module_05
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
                    //Default
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    //Added Fonts
                    fonts.AddFont("NotoSerifTC-ExtraBold.ttf", "SerifEB");
                    fonts.AddFont("NotoSerifTC-Black.ttf", "SerifBk");
                    fonts.AddFont("NotoSerifTC-Regular.ttf", "SerifR");
                    fonts.AddFont("ZenMaruGothic-Black.ttf", "ZMGB");
                    fonts.AddFont("ZenMaruGothic-Regular.ttf", "ZMGR");
                    fonts.AddFont("RampartOne-Regular.ttf", "ROR");
                    fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FA6FR");
                    fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FA6FS");
                    fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FA6BR");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
