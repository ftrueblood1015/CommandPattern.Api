using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CommandPattern.Api.Repositories.Mtg.ColorIdentities
{
    public class ColorIdentityRepository : RepositoryBase<ColorIdentity, CommandPatternContext>, IColorIdentityRepository
    {
        public ColorIdentityRepository(CommandPatternContext context) : base(context)
        {
        }
    }
}
