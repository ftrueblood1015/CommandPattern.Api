using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Pages.Mtg.CardTypes
{
    public partial class CardTypeSummary : SummaryPageBase<CardType>
    {
        private string DetailRoute = "cardtype";
    }
}
