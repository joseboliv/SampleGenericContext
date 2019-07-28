using DataAccessRepository.Services;
using DataAccessRepository.UoW;
using SampleGenericContext.Entities;
using System;

namespace SampleGenericContext
{
    public interface ITestService
    {
        void Run();
    }

    public class TestService : ITestService
    {
        private readonly IUowProvider _uowProvider;
        private readonly IAppLogger<TestService> _appLogger;
        public TestService(IUowProvider uowProvider, IAppLogger<TestService> appLogger)
        {
            _uowProvider = uowProvider;
            _appLogger = appLogger;
        }

        public void Run()
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repository = uow.GetRepository<Person>();

                var m = repository.GetAll(null, null);
            }

            _appLogger.LogInformation("Prueba de escritura");
            Console.WriteLine("testing");
        }
    }
}