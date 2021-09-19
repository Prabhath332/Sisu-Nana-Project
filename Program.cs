using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Sinks.Slack;

namespace web_project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Slack("https://hooks.slack.com/services/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", 20, TimeSpan.FromSeconds(10), "#general", "Test message", ":information_source:")
                .MinimumLevel.Debug()                               
                .CreateLogger();

           // Log.Information("Application Started...");

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
