﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Passku.Business.Concrete.MongoDb;
using Passku.DataAccess.Concrete.MongoDb;

namespace Passku.WebCoreApp
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
            IFileProvider physicalProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());

            string mongoConnectionString = this.Configuration.GetConnectionString("MongoConnectionString");
            services.AddTransient(s => new UserManager(new UserRepository(mongoConnectionString, "DbPasskuApp", "Users")));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IFileProvider>(physicalProvider);
            services.AddSession();
            services.AddMvc();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseStaticFiles();
            app.UseStatusCodePages();
        }
    }
}
