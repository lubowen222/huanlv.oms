using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Huanlv.Passport.ServerHost
{
    //class Program
    //{
    //    //static void Main(string[] args)
    //    //{
    //    //    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    //    //    var host = new ServiceHostBuilder()
    //    //        .RegisterServices(builder =>
    //    //        {
    //    //            builder.AddMicroService(option =>
    //    //            {
    //    //                option.AddServiceRuntime()
    //    //                .AddRelateService()
    //    //                .AddConfigurationWatch()
    //    //                //option.UseZooKeeperManager(new ConfigInfo("127.0.0.1:2181")); 
    //    //                .AddServiceEngine(typeof(SurgingServiceEngine));
    //    //                builder.Register(p => new CPlatformContainer(ServiceLocator.Current));
    //    //            });
    //    //        })
    //    //        .ConfigureLogging(logger =>
    //    //        {
    //    //            logger.AddConfiguration(
    //    //                Surging.Core.CPlatform.AppConfig.GetSection("Logging"));
    //    //        })
    //    //        .UseLog4net("${surgingpath}|Configs/log4net.config")
    //    //        .UseServer(options => { })
    //    //        .UseConsoleLifetime()
    //    //        .Configure(build =>
    //    //        build.AddCacheFile("${cachepath}|Configs/cacheSettings.json", basePath: AppContext.BaseDirectory, optional: false, reloadOnChange: true))
    //    //          .Configure(build =>
    //    //        build.AddCPlatformFile("${surgingpath}|Configs/surgingSettings.json", optional: false, reloadOnChange: true))
    //    //        .UseStartup<Startup>()
    //    //        .Build();

    //    //    using (host.Run())
    //    //    {
    //    //        Console.WriteLine($"服务端启动成功，{DateTime.Now}。");
    //    //    }
    //    //}
    //}
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
