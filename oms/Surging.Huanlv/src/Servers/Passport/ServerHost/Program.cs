using Autofac;
using Microsoft.Extensions.Logging;
using Surging.Core.AutoMapper;
using Surging.Core.Caching;
using Surging.Core.Caching.Configurations;
using Surging.Core.Consul.Configurations;
using Surging.Core.CPlatform;
using Surging.Core.CPlatform.Configurations;
using Surging.Core.CPlatform.Utilities;
using Surging.Core.Dapper;
using Surging.Core.EventBusRabbitMQ.Configurations;
using Surging.Core.ProxyGenerator;
using Surging.Core.ServiceHosting;
using Surging.Core.ServiceHosting.Internal.Implementation;
using Surging.Core.System.Intercept;
using System;

namespace Huanlv.Passport.ServerHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var host = new ServiceHostBuilder()
                 .RegisterServices(builder =>
                 {
                     builder.AddMicroService(option =>
                     {
                         option.AddServiceRuntime()
                          .AddClientProxy()
                          .AddRelateServiceRuntime()
                          .AddConfigurationWatch()
                          .AddCache()
                          .AddClientIntercepted(typeof(CacheProviderInterceptor))
                          .AddServiceEngine(typeof(SurgingServiceEngine))
                          .AddDapperRepository();

                         builder.Register(p => new CPlatformContainer(ServiceLocator.Current));
                     });
                 })
                 .ConfigureLogging(loggging =>
                 {
                     loggging.AddConfiguration(
                         Surging.Core.CPlatform.AppConfig.GetSection("Logging"));
                 })
                 .UseServer(options => { })
                 .UseConsoleLifetime()
                 .Configure(build =>
                 {
#if DEBUG
                     build.AddCacheFile("Configs/cacheSettings.json", optional: false, reloadOnChange: true);
                     build.AddCPlatformFile("Configs/surgingSettings.json", optional: false, reloadOnChange: true);
                     build.AddEventBusFile("Configs/eventBusSettings.json", optional: false);
                     build.AddConsulFile("Configs/consul.json", optional: false, reloadOnChange: true);


#else
                    build.AddCacheFile("${cachePath}|configs/cacheSettings.json", optional: false, reloadOnChange: true);                      
                    build.AddCPlatformFile("${surgingPath}|configs/surgingSettings.json", optional: false,reloadOnChange: true);                    
                    build.AddEventBusFile("configs/eventBusSettings.json", optional: false);
                    build.AddConsulFile("configs/consul.json", optional: false, reloadOnChange: true);
#endif
                 })
                 .UseProxy()
                 .UseStartup<Startup>()
                 .UserAutoMapper()
                 .Build();

            using (host.Run())
            {
                Console.WriteLine($"服务端启动成功，{DateTime.Now}。");
            }
        }
    }
}
