﻿using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using static Tests.Presentation.MAUIClient.DependencyInjection;
namespace Tests.Presentation.MAUIClient
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit().
            RegisterViewModels().
            RegisterPages().
            RegisterServices();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}