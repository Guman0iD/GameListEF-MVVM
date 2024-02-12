using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Procedures.Messages;
using Procedures.Services;
using Procedures.View;
using Procedures.ViewModel;

namespace Procedures
{
  
    public partial class App : Application
    {
        public static ServiceCollection ServiceCollection = null!;
        public static ServiceProvider ServiceProvider = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .Build();
            
            ServiceCollection = new ServiceCollection();
            ServiceCollection.AddSingleton<MainView>();
            ServiceCollection.AddSingleton<MainViewModel>();
            ServiceCollection.AddTransient<GamesListViewModel>();
            ServiceCollection.AddSingleton<AuthorizationView>();
            ServiceCollection.AddTransient<AuthorizationViewModel>();
            ServiceCollection.AddSingleton<RegisterView>();
            ServiceCollection.AddTransient<RegisterViewModel>();
            ServiceCollection.AddTransient<AppDbContext>();
            ServiceCollection.AddSingleton<SendAccountMessage>();
            
            ServiceCollection.AddSingleton<IConfiguration>(configuration);
            
            
            ServiceProvider = ServiceCollection.BuildServiceProvider();
            
            var view = ServiceProvider.GetService<MainView>()!;
            view.Show();
        }
    }
}