using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;

namespace CommandPattern.Api.Repositories.Mtg.Rarities
{
    public class RarityRepository : RepositoryBase<Rarity, CommandPatternContext>, IRarityRepository
    {
        public RarityRepository(CommandPatternContext context) : base(context)
        {
        }
    }
}
