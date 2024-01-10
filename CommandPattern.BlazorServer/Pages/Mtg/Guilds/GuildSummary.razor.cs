using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Pages.Mtg.Guilds
{
    public partial class GuildSummary : SummaryPageBase<Guild>
    {
        private string DetailRoute = "guild";
    }
}
