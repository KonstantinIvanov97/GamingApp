using GamingApp.Data;
using GamingApp.Services;
using GamingApp.Services.Interfaces;
using GamingApp.ViewModels;
using GamingApp.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace GamingApp
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        // za sega ne se polzva no moje da se naloji za da stane po-gotino
        //public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            this.ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainView = new MainView();

            mainView.DataContext = new MainViewModel(ServiceProvider);

            mainView.Show();

            base.OnStartup(e);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            //Views
            services.AddScoped<RegisterUserView>();
            services.AddScoped<LoginUserView>();

            //ViewModels
            services.AddScoped<RegisterUserViewModel>();
            services.AddScoped<LoginUserViewModel>();

            //Services
            services.AddScoped<IUserService, UserService>();

            //Db
            services.AddScoped(typeof(IRepository<>), typeof(DbRepository<>));

            services.AddDbContext<GamingAppDbContext>(options =>
            {
                options.UseSqlServer("Server=.;Database=GamingApp;Trusted_Connection=True;MultipleActiveResultSets=true");
            });
        }

        //TODO Messenger pattern
        //TODO Observe pattern
        //
    }
}
