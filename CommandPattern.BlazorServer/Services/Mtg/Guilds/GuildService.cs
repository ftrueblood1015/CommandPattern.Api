using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.Guilds
{
    public class GuildService : ServiceBase<Guild>
    {
        public GuildService(ApiServerClient apiServerClient) : base(apiServerClient, "Guild")
        {
        }
    }
}
