using CommandPattern.Api.Repositories.Mtg.Rarities;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.Rarities
{
    public class RarityService : ServiceBase<Rarity, IRarityRepository>, IRarityService
    {
        public RarityService(IRepositoryBase<Rarity> repo) : base(repo)
        {
        }
    }
}
