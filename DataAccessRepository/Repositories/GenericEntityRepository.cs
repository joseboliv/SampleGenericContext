using DataAccessRepository.Context;
using DataAccessRepository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DataAccessRepository.Repositories
{
    public class GenericEntityRepository<TEntity> : EntityRepositoryBase<DbContext, TEntity> where TEntity : EntityBase, new()
    {
        public GenericEntityRepository(ILogger<DataAccess> logger) : base(logger, null)
        { }
    }
}