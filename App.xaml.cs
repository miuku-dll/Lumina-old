using Lumina.Services;
using Lumina.ViewModels.Pages;
using Lumina.ViewModels.Windows;
using Lumina.Views.Pages;
using Lumina.Views.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Threading;
using Wpf.Ui;

namespace Lumina
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        // The.NET Generic Host provides dependency injection, configuration, logging, and other services.
        // https://docs.microsoft.com/dotnet/core/extensions/generic-host
        // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
        // https://docs.microsoft.com/dotnet/core/extensions/configuration
        // https://docs.microsoft.com/dotnet/core/extensions/logging
        private static readonly IHost _host = Host
            .CreateDefaultBuilder()
            .ConfigureAppConfiguration(c => { c.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)); })
            .ConfigureServices((context, services) =>
            {
                services.AddHostedService<ApplicationHostService>();

                // Page resolver service
                services.AddSingleton<IPageService, PageService>();

                // Theme manipulation
                services.AddSingleton<IThemeService, ThemeService>();

                // TaskBar manipulation
                services.AddSingleton<ITaskBarService, TaskBarService>();

                // Service containing navigation, same as INavigationWindow... but without window
                services.AddSingleton<INavigationService, NavigationService>();

                // Main window with navigation
                services.AddSingleton<INavigationWindow, MainWindow>();
                services.AddSingleton<MainWindowViewModel>();

                services.AddSingleton<DashboardPage>();
                services.AddSingleton<DashboardViewModel>();
                services.AddSingleton<FeaturesPage>();
                services.AddSingleton<FeaturesViewModel>();
                services.AddSingleton<SettingsPage>();
                services.AddSingleton<SettingsViewModel>();
            }).Build();

        /// <summary>
        /// Gets registered service.
        /// </summary>
        /// <typeparam name="T">Type of the service to get.</typeparam>
        /// <returns>Instance of the service or <see langword="null"/>.</returns>
        public static T GetService<T>()
            where T : class
        {
            return _host.Services.GetService(typeof(T)) as T;
        }

        /// <summary>
        /// Occurs when the application is loading.
        /// </summary>
        public void OnStartup(object sender, StartupEventArgs e)
        {
            try
            {
                Webhooks.WebhookLaunch();
                DashboardViewModel viewModel = new DashboardViewModel();
                
            }
            catch { }

            try
            {
                var PrivateServerFile = "./Config/PrivateServer.txt";
                var WebhookLocation = "./Config/Webhook.txt";
                var CollectStatus = "./Config/Status1.txt";
                var CraftStatus = "./Config/Status2.txt";

                if (!Directory.Exists("./Config/"))
                {
                    // Try to create the Path.
                    DirectoryInfo di = Directory.CreateDirectory("./Config");
                    Console.WriteLine("Path Created...");

                    var Path = "off"; // Too lazy to find out myself for now
                    using (FileStream fs = File.Create(@".\Config\Status1.txt"))
                    {
                        char[] value = Path.ToCharArray();
                        fs.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
                    }
                }
                else { }

                if (File.Exists(CraftStatus))
                {
                    goto Address;
                }
                else
                {
                    Console.WriteLine("Adding Files...");
                    using (FileStream fs = File.Create(PrivateServerFile))
                    {
                        char[] value = "".ToCharArray();
                        fs.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
                    }
                    using (FileStream fs = File.Create(WebhookLocation))
                    {
                        char[] value = "".ToCharArray();
                        fs.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
                    }
                    using (FileStream fs = File.Create(CollectStatus))
                    {
                        char[] value = "".ToCharArray();
                        fs.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
                    }
                    using (FileStream fs = File.Create(CraftStatus))
                    {
                        char[] value = "".ToCharArray();
                        fs.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);
                    }
                }


                Console.WriteLine("Done Checking Folder...");
                Thread.Sleep(1000);
                Console.Clear();
            }
            catch { }

            Address:

            _host.Start();
        }

        /// <summary>
        /// Occurs when the application is closing.
        /// </summary>
        private async void OnExit(object sender, ExitEventArgs e)
        {
            await _host.StopAsync();

            _host.Dispose();
        }

        /// <summary>
        /// Occurs when an exception is thrown by an application but not handled.
        /// </summary>
        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // For more info see https://docs.microsoft.com/en-us/dotnet/api/system.windows.application.dispatcherunhandledexception?view=windowsdesktop-6.0
        }
    }
}
