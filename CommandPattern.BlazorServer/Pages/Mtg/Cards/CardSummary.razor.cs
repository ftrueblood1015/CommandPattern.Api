using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Pages.Mtg.Cards
{
    public partial class CardSummary : SummaryPageBase<Card>
    {
        private string DetailRoute = "card";

        public override Func<Card, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Description!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.IsActive}".Contains(_searchString))
                return true;

            if (x.Set!.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.CardType!.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.ColorIdentity!.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Rarity!.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.CardPurpose!.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        };
    }
}
