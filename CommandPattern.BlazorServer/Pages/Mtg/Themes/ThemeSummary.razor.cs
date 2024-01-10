using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Pages.Mtg.Themes
{
    public partial class ThemeSummary : SummaryPageBase<Theme>
    {
        private string DetailRoute = "theme";
    }
}
