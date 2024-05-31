namespace Redis;

using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
		IHost host = CreateHostBuilder(args).Build();

        host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
			{
				webBuilder.UseStartup<Startup>();
			});
}