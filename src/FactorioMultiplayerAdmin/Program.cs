using Microsoft.AspNetCore.Hosting;

namespace FactorioMultiplayerAdmin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseUrls("http://+:5000")
                .Build();

            host.Run();
        }
    }
}
