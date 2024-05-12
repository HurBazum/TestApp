using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;
using Test.BLL.Services;
using Test.DAL;
using Test.PLL.ViewModels.Services;

namespace Test.PLL
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static IHost? _host;

        public static IHost Host => _host ?? Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        protected override void OnStartup(StartupEventArgs e)
        {
            var host = Host;
            base.OnStartup(e);
            host.StartAsync().ConfigureAwait(false);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            var host = Host;
            host.StopAsync().ConfigureAwait(false);
            host.Dispose();
            _host = null;
        }

        public static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .AddDatabase()
            .AddRepositories()
            .AddServices()
            .AddViewModels();
    }

}
