using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.Themes
{
    public class ThemeService : ServiceBase<Theme>, IThemeService
    {
        public ThemeService(ApiServerClient apiServerClient) : base(apiServerClient, "Theme")
        {
        }
    }
}
