using WebApplication4;



// Add services to the container.

public  class Program
{
    public static void Main(string[] args)
    {
        var builder = CreateHostBuilder(args);
        var app = builder.Build();
        app.Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                webBuilder.UseUrls($"https://0.0.0.0:7038");
            });
}