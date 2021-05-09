using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Platzi_MVC_CSharp.Models;

namespace Platzi_MVC_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host= CreateHostBuilder(args).Build();
            //CreateHostBuilder(args).Build().Run();
            /**revisión y aseguramiendo de que la base de datos sea creada antes de lanzar el web server
            se llaman los servicios de la variable host  */
            var scope = host.Services.CreateScope();
            var services= scope.ServiceProvider;
            try{
            var context = services.GetRequiredService<EscuelaContext>();
            context.Database.EnsureCreated();
            }catch(Exception ex){
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occurred creating the database");
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
