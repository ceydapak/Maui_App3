namespace Graduation_project;

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
        string _dbpath = Path.Combine(FileSystem.AppDataDirectory, "program.db");
        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DBTrans>(s, _dbpath));
        return builder.Build();
	}
}
