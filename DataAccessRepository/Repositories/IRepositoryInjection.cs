using Microsoft.EntityFrameworkCore;

namespace DataAccessRepository.Repositories
{
    public interface IRepositoryInjection
    {
        IRepositoryInjection SetContext(DbContext context);
    }
}