using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.BlazorServer.Pages.Mtg.Sets
{
    public partial class MtgSetSummary : SummaryPageBase<Set>
    {
        private string DetailRoute = "mtgset";

        public override Func<Set, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Description!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.IsActive}".Contains(_searchString))
                return true;

            if ($"{x.ReleaseYear}".Contains(_searchString))
                return true;

            return false;
        };
    }
}
