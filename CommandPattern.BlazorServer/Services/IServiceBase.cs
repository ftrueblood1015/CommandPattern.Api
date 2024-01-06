namespace CommandPattern.BlazorServer.Services
{
    public interface IServiceBase<T> where T : class
    {
        Task<T?> InsertEntity(T entity);

        Task<T?> UpdateEntity(T entity);

        Task<IEnumerable<T>?> GetAllEntities();

        Task<T?> GetEntity(long id);

        Task<bool> DeleteEntity(long id);

        Func<Task<IEnumerable<T>>>? Populate { get; set; }
    }
}
