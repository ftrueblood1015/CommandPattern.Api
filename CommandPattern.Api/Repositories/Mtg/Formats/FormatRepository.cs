using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;

namespace CommandPattern.Api.Repositories.Mtg.Formats
{
    public class FormatRepository : RepositoryBase<Format, CommandPatternContext>, IFormatRepository
    {
        public FormatRepository(CommandPatternContext context) : base(context)
        {
        }
    }
}
