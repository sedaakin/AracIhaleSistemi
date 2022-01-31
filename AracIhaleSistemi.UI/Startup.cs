using AracIhaleSistemi.UI.ApiServices;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AracIhaleSistemi.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false).AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddHttpClient<AracApiService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["baseUrl"]);
            }
            );
            services.AddHttpClient<DurumApiService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["baseUrl"]);
            }
            );
            services.AddHttpClient<KomisyonApiService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["baseUrl"]);
            }
           );
            services.AddHttpClient<LoginApiService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["baseUrl"]);
            }
            );
            services.AddHttpClient<NoterApiService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["baseUrl"]);
            }
           );
            services.AddHttpClient<PaketDetayApiService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["baseUrl"]);
            }
            );            
            services.AddHttpClient<PaketTipApiService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["baseUrl"]);
            }
            );
            services.AddHttpClient<UyeApiService>(options =>
            {
                options.BaseAddress = new Uri(Configuration["baseUrl"]);
            }
);
            services.AddKendo();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areaDefault",
                    pattern: "{area:exists}/{controller=Arac}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");

            });

            
        }
    }
}
