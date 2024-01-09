using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Pages.Mtg.CardPurposes
{
    public partial class CardPurposeSummary : SummaryPageBase<CardPurpose>
    {
        private string DetailRoute = "cardpurpose";
    }
}
