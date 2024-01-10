using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CommandPattern.Api.Repositories.Mtg.Themes
{
    public class ThemeRepository : RepositoryBase<Theme, CommandPatternContext>, IThemeRepository
    {
        public ThemeRepository(CommandPatternContext context) : base(context)
        {
        }
    }
}
