using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Routing;
using WebTestEmptyApp2.Services;

namespace WebTestEmptyApp2
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //app.UseServices(service => { service.AddMvc(); });
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<ICustomer, CustomerService>();
        }
    }
}
