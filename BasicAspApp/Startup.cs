using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BasicAspApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BasicAspApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json")
                .AddUserSecrets("c05815b4-63bb-44fd-98e3-879783beb05d");
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<BasicAspDBContext>(options => options
                //.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BasicAsp;Trusted_Connection=True;MultipleActiveResultSets=true")
                //.UseSqlServer(Configuration.GetConnectionString("database.connection"))
                .UseSqlServer(Configuration["database:connection"])
                .EnableSensitiveDataLogging(true));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseDefaultFiles();
            //app.UseStaticFiles();
            app.UseFileServer();                // it is a combination of app.UseDefaultFiles() & app.UseStaticFiles()
            //app.UseMvcWithDefaultRoute();     // HomeController will work with this middleware
            app.UseMvc(ConfigureRoute);

            //app.UseWelcomePage(); 

            //app.Run() 方法中注册的中间件永远不会有机会调用另一个中间件，它只会接收请求，然后必须产生某种响应
            //如果在 app.Run() 方法之后注册另一个中间件，那么注册的那个中间件永远不会被调用，因为 Run() 方法是注册中间件的 终端，在它之后，永远不会调用下一个中间件
            app.Run(async (context) =>
            {
                //throw new Exception("user generated exception.");
                var msg = Configuration["message"];
                await context.Response.WriteAsync(msg);
            });

        }
        private void ConfigureRoute(IRouteBuilder routeBuilder)
        {
            //routeBuilder.MapRoute("Default", "{controller}/{action}/{id?}"); 
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");    //Add default value: /Home/Index
        }
    }
}
