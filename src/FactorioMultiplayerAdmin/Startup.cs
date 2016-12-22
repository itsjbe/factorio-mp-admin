using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FactorioMultiplayerAdmin
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.Run(async context =>
            //        {
            //            await context.Response.WriteAsync("Hello World!!!");
            //        });

            app.UseMvc();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
    }
}