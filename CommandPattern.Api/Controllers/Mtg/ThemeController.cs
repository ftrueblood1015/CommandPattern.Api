using CommandPattern.Api.Services.Mtg.CardPurposes;
using CommandPattern.Api.Services.Mtg.Themes;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class ThemeController : ControllerBase<Theme, IThemeService>
    {
        public ThemeController(IThemeService service) : base(service)
        {
        }
    }
}
