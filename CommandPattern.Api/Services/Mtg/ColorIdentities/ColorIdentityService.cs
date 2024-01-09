using CommandPattern.Api.Repositories.Mtg.ColorIdentities;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.ColorIdentities
{
    public class ColorIdentityService : ServiceBase<ColorIdentity, IColorIdentityRepository>, IColorIdentityService
    {
        public ColorIdentityService(IRepositoryBase<ColorIdentity> repo) : base(repo)
        {
        }
    }
}
