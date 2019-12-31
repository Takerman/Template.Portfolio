using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Takerman.Portfolio.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseStatusCodePages();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();

            //    endpoints.MapAreaControllerRoute("areas", "Tanyo", "tanyo.takerman.net");

            //    endpoints.MapGet(
            //        name: "areas",
            //        template: "{area:exists}/{controller=Home}/{action=Index}");

            //    endpoints.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");

            //    endpoints.MapGet("/", context => context.Response.WriteAsync("Hi Contoso!"))
            //        .RequireHost("contoso.com");
            //    endpoints.MapGet("/", context => context.Response.WriteAsync("Hi AdventureWorks!"))
            //        .RequireHost("adventure-works.com");
            //    endpoints.MapHealthChecks("/healthz").RequireHost("*:8080");
            //});
        }
    }
}