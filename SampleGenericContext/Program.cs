using DataAccessRepository;
using DataAccessRepository.Services;
using DataAccessRepository.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SampleGenericContext.AppContext;

namespace SampleGenericContext
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // create service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // entry to run app
            serviceProvider.GetService<App>().Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // add services
            services.AddTransient<ITestService, TestService>();

            var connection = @"Server=HP6120DEV\MSSQLSERVER2017;Database=RepositoryContext;User Id=sa;Password=Pa$$w0rd2018;";

            services.AddDbContext<SampleAppContext>(options => options.UseSqlServer(connection.ToString()));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddDataAccess<SampleAppContext>();

            // add app
            services.AddTransient<App>();
        }
    }
}
