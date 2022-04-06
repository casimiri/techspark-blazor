using Microsoft.AspNetCore.Components.WebView.Maui;
using MudBlazor.Services;
using TechSpark.Blazor.DesktopTeam.UI.Data;

namespace TechSpark.Blazor.DesktopTeam.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .RegisterBlazorMauiWebView()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddBlazorWebView();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddMudServices();

            return builder.Build();
        }
    }
}