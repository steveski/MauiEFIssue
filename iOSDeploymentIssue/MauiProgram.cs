using iOSDeploymentIssue.Database;
using iOSDeploymentIssue.ViewModels;

namespace iOSDeploymentIssue;

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

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "logbook.db");

        builder.Services.AddTransient(x =>
        {
            
            var db = new EntityDbContext(dbPath);
            db.Database.EnsureCreated();

            return db;
        });


        builder.Services.AddTransient<MainPageViewModel>();

        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
	}
}
