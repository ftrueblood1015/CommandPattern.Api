using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Pages.Mtg.ColorIdentities
{
    public partial class ColorIdentitySummary : SummaryPageBase<ColorIdentity>
    {
        private string DetailRoute = "coloridentity";

        public override Func<ColorIdentity, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Description!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.IsActive}".Contains(_searchString))
                return true;

            return false;
        };
    }
}
