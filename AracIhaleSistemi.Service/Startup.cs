using AracIhaleSistemi.DataAccess.DAL;
using AracIhaleSistemi.DataAccess.DAL.Interfaces;
using AracIhaleSistemi.Service.Auth;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.Service
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
            services.AddControllers();         
            services.AddScoped<IAracDAL, AracDAL>();
            services.AddScoped<IAracDetayDAL, AracDetayDAL>();
            services.AddScoped<IAracOzellikDAL, AracOzellikDAL>();
            services.AddScoped<IDurumDAL, DurumDAL>();
            services.AddScoped<ITramerDAL, TramerDAL>();
            services.AddScoped<IUyeDAL, UyeDAL>();
            services.AddScoped<IRolDAL, RolDAL>();
            services.AddScoped<IPaketDetayDAL, PaketDetayDAL>();
            services.AddScoped<IPaketTipDAL, PaketTipDAL>();
            services.AddScoped<IKomisyonDAL, KomisyonDAL>();
            services.AddScoped<INoterUcretDAL, NoterUcretDAL>();
            services.AddScoped<IAuthRepo, AuthRepo>();
            // services.AddScoped<IMapper, Mapper>();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            });
            services.AddSwaggerGen(a =>
            {
                a.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                { Title = "asdlasd", Version = "v1" });
            });
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"])),
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();
            app.UseCors(builder=>builder.WithOrigins("http://localhost:44350").AllowAnyHeader());

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "MyAPI V1");
            });
        }
        }
    }
}
