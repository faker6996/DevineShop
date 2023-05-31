using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MARShop.API
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
                    webBuilder.UseUrls("http://103.229.41.235:5001");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
