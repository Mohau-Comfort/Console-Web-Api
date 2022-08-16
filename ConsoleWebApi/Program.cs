using System;

namespace ConsoleWebApi
{

    class Program
    {

        static void Main(String[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(String[] args) =>

           Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHost =>
            {
                webHost.UseStartup<ConsoleWebApi.Startup>();
            });

    }

}
