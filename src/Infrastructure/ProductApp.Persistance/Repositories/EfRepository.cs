using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using System.Linq.Expressions;

namespace ProductApp.Persistance.Repositories
{
    public class EfRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
