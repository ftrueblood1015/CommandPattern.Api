using System.Text;
using System.Text.Json;

namespace CommandPattern.BlazorServer.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected readonly ApiServerClient ApiServerClient;
        protected readonly string ControllerName;

        public ServiceBase(ApiServerClient apiServerClient, string controllerName)
        {
            ApiServerClient = apiServerClient;
            ControllerName = controllerName;
        }

        public Func<Task<IEnumerable<T>>>? Populate { get; set; }

        public virtual async Task<bool> DeleteEntity(long id)
        {
            var url = new Uri($"{ControllerName}/{id}", UriKind.Relative);
            var response = await ApiServerClient.Client.DeleteAsync(url);

            return response.IsSuccessStatusCode;
        }

        public virtual async Task<IEnumerable<T>?> GetAllEntities()
        {
            var url = new Uri($"{ControllerName}", UriKind.Relative);

            return await ApiServerClient.GetData<IEnumerable<T>>(url);
        }

        public virtual async Task<T?> GetEntity(long id)
        {
            var url = new Uri($"{ControllerName}/{id}", UriKind.Relative);
            return await ApiServerClient.GetData<T>(url);
        }

        public virtual async Task<T?> InsertEntity(T entity)
        {
            using var TJson = new StringContent(JsonSerializer.Serialize(entity), Encoding.UTF8, "application/json");
            var url = new Uri($"{ControllerName}", UriKind.Relative);
            var response = await ApiServerClient.Client.PostAsync(url, TJson);

            return await response.GetData<T>();
        }

        public virtual async Task<T?> UpdateEntity(T entity)
        {
            var url = new Uri($"{ControllerName}", UriKind.Relative);
            using var TJson = new StringContent(JsonSerializer.Serialize(entity), Encoding.UTF8, "application/json");
            var response = await ApiServerClient.Client.PutAsync(url, TJson);

            return await response.GetData<T>();
        }
    }
}
