using CommandPattern.Domain.Entities;
using CommandPattern.Domain.Models.Entities;

namespace CommandPattern.Domain.Services
{
    public interface IEntityModelServiceBase<TEntity, TModel>
    where TEntity : class, IEntityBase
    where TModel : class, IEntityModelBase
    {
        TModel Add(TModel entity);

        bool Delete(TModel entity);

        bool DeleteById(int entityId);

        IEnumerable<TModel> Filter(Func<TModel, bool> predicate);

        IEnumerable<TModel> GetAll();

        TModel? GetById(int id);

        TModel Update(TModel entity);
    }
}
