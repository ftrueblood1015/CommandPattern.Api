using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Pages.Mtg.Decks
{
    public partial class DeckSummary : SummaryPageBase<Deck>
    {
        private string DetailRoute = "deck";

        public override Func<Deck, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Description!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.IsActive}".Contains(_searchString))
                return true;

            if (x.Theme!.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Guild!.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Format!.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        };
    }
}
