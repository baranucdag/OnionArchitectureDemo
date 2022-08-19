using ProductApp.Domain.Common;
using System.Linq.Expressions;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(Expression<Func<T, bool>> predicate);
        List<T> GetAll(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
