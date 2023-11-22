using Ecommerce.Application.Persistence;
using Ecommerce.Infrastructure.Persistence;
using System.Collections;

namespace Ecommerce.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private Hashtable? _repositories;
        private readonly EcommerceDbContext _dbContext;

        public UnitOfWork(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Complete()
        {
            try
            {
                return await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en transaccion: ", ex);
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositories is null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _dbContext);
                _repositories.Add(type, repositoryInstance);
            }

            return (IAsyncRepository<TEntity>)_repositories[type]!;
        }
    }
}
