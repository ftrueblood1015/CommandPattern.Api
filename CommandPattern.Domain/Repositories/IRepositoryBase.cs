using CommandPattern.Domain.Entities;

namespace CommandPattern.Domain.Repositories
{
    public interface IRepositoryBase<T>
    where T : class, IEntityBase
    {
        T Add(T entity);

        bool Delete(T entity);

        bool DeleteById(long entityId);

        IEnumerable<T> Filter(Func<T, bool> predicate);

        IEnumerable<T> GetAll();

        T? GetById(long id);

        T Update(T entity);
    }
}
