using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace TrelloClone.Data
{
     public static class MigrationManager
     {
          public static IHost MigrateDatabase(this IHost host)
          {
               using (var scope = host.Services.CreateScope())
               {
                    using (var appContext = scope.ServiceProvider
                       .GetRequiredService<TrelloCloneDbContext>())
                    {
                         try
                         {
                              appContext.Database.EnsureCreated();
                              appContext.Database.Migrate();
                         }
                         catch
                         {

                         }
                    }
               }

               return host;
          }
     }
}
