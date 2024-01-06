using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.Sets
{
    public class SetService : ServiceBase<Set>, ISetService
    {
        public SetService(ApiServerClient apiServerClient) : base(apiServerClient, "Set")
        {
        }
    }
}
