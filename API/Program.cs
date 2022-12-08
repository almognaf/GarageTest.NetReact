using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
          var host = CreateHostBuilder(args).Build();

          using var scope = host.Services.CreateScope();

          var services = scope.ServiceProvider;
          try
          {
            var context = services.GetRequiredService<DataContext>();
            await context.Database.MigrateAsync();
            await Seed.SeedData(context);
          }
          catch(Exception ex)
          {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occure during the Activity migration");
          }
          try
          {
            var garageContext = services.GetRequiredService<GarageDataContext>();
            await garageContext.Database.MigrateAsync();
            await GarageDataSeed.SeedData(garageContext);
          }
          catch(Exception ex)
          {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occure during the Garage migration");
          }
           await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

