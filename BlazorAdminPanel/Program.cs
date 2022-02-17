using BlazorAdminPanel.DataBase;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorAdminPanel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                
                {
                    webBuilder.UseStartup<Startup>();
                }).ConfigureServices((host, services)=>
                {
                    services.AddSingleton(host.Configuration);
                    services.AddDbContext<ApplicationContext>();
                    services.AddDistributedMemoryCache();
                    services.AddSession();
                });
        
    }
}
