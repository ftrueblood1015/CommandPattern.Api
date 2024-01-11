using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.Formats
{
    public partial class FormatDetail : DetailPageBase<Format>
    {
        [Parameter]
        public int EntityId { get; set; }

        public Format? Entity { get; set; } = new Format();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<Format> SetEntity()
        {
            if (EntityId == 0)
            {
                return new Format();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }
    }
}
