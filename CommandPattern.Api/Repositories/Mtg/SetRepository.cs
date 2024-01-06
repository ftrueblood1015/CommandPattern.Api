using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CommandPattern.Api.Repositories.Mtg
{
    public class SetRepository : RepositoryBase<Set, CommandPatternContext>, ISetRepository
    {
        public SetRepository(CommandPatternContext context) : base(context)
        {
        }
    }
}
