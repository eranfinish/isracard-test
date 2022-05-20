using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SailPointTest
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
            services.AddCors(options => {
                options.AddPolicy( "MyPolicy",
                policy =>
                {
                    policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();

                });
            });
            services.AddControllers();
         

            //options => {     builder =>
            //{
                       
            //           .builder.WithOrigins("http://localhost:4200")
            //           .AllowAnyHeader()
            //           .AllowAnyMethod();
            //});
            //     options.AllowAnyOrigin().AddPolicy(name: "MyPolicy",
            // policy =>
            // {
            //     policy.WithOrigins("http://localhost:4200/")
            //             .WithMethods("PUT", "DELETE", "GET");
            // });

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
                app.UseHsts();
            }
            app.UseRouting();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseHttpsRedirection();
         
            // global cors policy
            app.UseCors("MyPolicy");
            //app.UseCors(x => x
            //    .AllowAnyMethod()
            //    .AllowAnyHeader()
            //    .SetIsOriginAllowed(origin => true) // allow any origin
            //    .AllowCredentials()); // allow credentials

        //    app.UseAuthentication();
       //     app.UseMvc();
//app.UseAuthorization();
      
        }
    }
}
