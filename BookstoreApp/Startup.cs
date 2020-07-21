using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookstoreApp.Data;
using BookstoreApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace BookstoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookStoreContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookstoreApp;Trusted_Connection = True;MultipleActiveResultSets=true"));
            services.AddControllersWithViews();
            // same as above   services.AddMvc();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddScoped<BookRepository, BookRepository>();
#endif
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
            app.UseStaticFiles(); //to be used in the case of wwwroot folder (by default)

            /*app.UseStaticFiles(new StaticFileOptions()    to be used in the case of any other folder containing static files
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"Name of the folder in which files are present"))
            });*/

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
