using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace web_project.Data
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<web_projectContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {    
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
