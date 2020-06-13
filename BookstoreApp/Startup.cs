using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookstoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // same as above   services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //IWebHoster tells us about the current environment which is development right now.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           /* app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from middleware");
                await next();
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from second middleware");
                await next();
            });*/
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                /*endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("\n Hello World! \n You are woking in the " + env.EnvironmentName +"environment");
                });*/
            });

           /* app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/kanika", async context =>
                {
                    await context.Response.WriteAsync("Hello Kanika!");
                });
            });*/
        }
    }
}
