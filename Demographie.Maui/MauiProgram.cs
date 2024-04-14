using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Demographie.Maui.Views;
using Demographie.Maui.Services;
using Demographie.Maui.ViewModels;
namespace Demographie.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            // Enregistrer les Services et les pages pour Dependency Injection
            builder.Services.AddSingleton<PersonneService>();
            builder.Services.AddSingleton<Views.PersonnesPage>();
            builder.Services.AddSingleton<PersonnesPageViewModel>();
            builder.Services.AddSingleton<AddPersonnePage>();
            builder.Services.AddSingleton<AddPersonnePageViewModel>();
            builder.Services.AddSingleton<PersonnesDatabase>();


            return builder.Build();
        }
    }
}
