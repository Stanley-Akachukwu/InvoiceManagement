using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;
using System;
using TakeHome.WebAPI.CustomExceptionMiddleware;
using TakeHome.WebAPI.Data;
using TakeHome.WebAPI.Data.Abstract;
using TakeHome.WebAPI.Data.Concrete;
using TakeHome.WebAPI.Mappings;

namespace TakeHome.WebAPI
{
    public class Startup
    {
      //  private readonly IOptions<AuthSettings> _authSettings;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           // _authSettings = authSettings;
        }

        public IConfiguration Configuration
        {
            get;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            
            services.AddRazorPages();
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddDbContext<TakeHomeDbContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TakeHome Task API",
                    Version = "v1",
                    Description = "TakeHome Task API.",
                    Contact = new OpenApiContact
                    {
                        Name = "Stanley Akachukwu",
                        Email = string.Empty,
                        Url = new Uri("https://stannedu.com/"),
                    },
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "UCare API V1");
                c.RoutePrefix = "swagger/ui"; 
            });
            app.UseStaticFiles();
            app.UseSerilogRequestLogging();
            //app.ConfigureExceptionHandler(logger);
            app.ConfigureCustomExceptionMiddleware();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}