using aspcoreempty1.modal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspcoreempty1
{
    public class Startup
    {
        public IConfiguration Configuration { get; } ////read key value pair->IConfiguration
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();
            //services.AddMvc();
            services.AddSingleton<ICarRepository, MockCarRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
     public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
        {
            SourceCodeLineCount = 5
        };

        app.UseDeveloperExceptionPage(developerExceptionPageOptions);
    }

    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
                    name: "default",
                     pattern: "{controller=Home}/{action=Index}/{id?}");

    });
        
}
    }
}
