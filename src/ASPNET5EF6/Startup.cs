using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Routing;

namespace WebApplication3
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // Add MVC to the request pipeline.
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Ninja", action = "Index" });
            });
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
    }
}
