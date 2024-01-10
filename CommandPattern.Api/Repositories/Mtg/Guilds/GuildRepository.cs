using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;

namespace CommandPattern.Api.Repositories.Mtg.Guilds
{
    public class GuildRepository : RepositoryBase<Guild, CommandPatternContext>, IGuildRepository
    {
        public GuildRepository(CommandPatternContext context) : base(context)
        {
        }
    }
}
