using CommandPattern.Api.Repositories.Mtg.Guilds;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.Guilds
{
    public class GuildService : ServiceBase<Guild, IGuildRepository>, IGuildService
    {
        public GuildService(IRepositoryBase<Guild> repo) : base(repo)
        {
        }
    }
}
