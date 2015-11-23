﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.Diagnostics.Entity;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Routing;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using AspNetDemo.Models;
using aspnetv5;
using aspnetv5.Middleware;
using Microsoft.Dnx.Runtime;
using Microsoft.Extensions.PlatformAbstractions;

namespace AspNetDemo
{
    public class Startup
    {
        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            // Setup configuration sources.
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();

            Configuration = configBuilder.Build();
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add Application settings to the services container.
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            
            // Add MVC services to the services container.
            services.AddMvc();
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerfactory)
        {
            // Configure the HTTP request pipeline.

            // Add the console logger.
            loggerfactory.AddConsole(minLevel: LogLevel.Warning);

            NlogConfigurator.Go();
            CommonLoggingConfigurator.Go();
            
            // Add the following to the request pipeline only in development environment.
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage(options => options.EnableAll());
            }
            else
            {
                // Add Error handling middleware which catches all application specific errors and
                // sends the request to the following path or controller action.
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseIISPlatformHandler();

            app.UseNaiveLogOnErrorMiddleware();

            // Add static files to the request pipeline.
            app.UseStaticFiles();
            
            // Add MVC to the request pipeline.
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                   name: "typeScriptDemo",
                   template: "ts/{*.}",
                   defaults: new { controller = "typescriptDemo", action = "Index" });
            });
        }

        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
