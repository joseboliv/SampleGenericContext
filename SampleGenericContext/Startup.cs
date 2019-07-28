using DataAccessRepository;
using DataAccessRepository.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SampleGenericContext.AppContext;

namespace SampleGenericContext
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        private static IServiceCollection  ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            var connection = @"Server=HP6120DEV\MSSQLSERVER2017;Port=1033;Database=RepositoryContext;User Id=sa;Password=Pa$$w0rd2018;";

            services.AddDbContext<SampleAppContext>(options => options.UseSqlServer(connection.ToString()));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddDataAccess<SampleAppContext>();
            services.AddTransient<Program>();

            return services;
        }
    }
}