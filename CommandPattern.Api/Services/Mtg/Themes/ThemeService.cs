using CommandPattern.Api.Repositories.Mtg.Themes;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.Themes
{
    public class ThemeService : ServiceBase<Theme, IThemeRepository>, IThemeService
    {
        public ThemeService(IRepositoryBase<Theme> repo) : base(repo)
        {
        }
    }
}
