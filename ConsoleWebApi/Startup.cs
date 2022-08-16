using ConsoleWebApi.Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleWebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<Custom_Middleware1>();

            services.AddSingleton<IProductRepositry, ProductRepositry>(); 
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            ////Use Method
            //app.Use(async (context, next) =>
            //{
                
            //     await context.Response.WriteAsync("Hello from Use 1 of 1 \n");

            //    await next();

            //    await context.Response.WriteAsync("Hello from Use 1 of 2 \n");
            //});

            //app.UseMiddleware<Custom_Middleware1>();

            //app.Map("/mohau", CustomeCode);

            ////Use Method 2
            //app.Use(async (context, next) =>
            //{

            //    await context.Response.WriteAsync("Hello from Use 2 of 1 \n");

            //    await next();

            //    await context.Response.WriteAsync("Hello from Use 2 of 2 \n");
            //});

            ////Run Method
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run Mate \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Routing
            app.UseRouting();

            //Mapping
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void CustomeCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await next();
            });
        }
    }
}
