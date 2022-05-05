#if ANDROID
using Repro6815.Platforms.Android;
#elif WINDOWS
using Repro6815.Platforms.Windows;
#endif

namespace Repro6815;

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

#if ANDROID || WINDOWS
		builder.Services.AddTransient<ISomethingService, SomethingService>();
#endif

		return builder.Build();
	}
}
