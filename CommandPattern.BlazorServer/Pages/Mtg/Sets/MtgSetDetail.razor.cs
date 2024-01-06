using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.Sets
{
    public partial class MtgSetDetail : DetailPageBase<Set>
    {
        [Parameter]
        public int EntityId { get; set; }

        public Set? Entity { get; set; } = new Set();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<Set> SetEntity()
        {
            if (EntityId == 0)
            {
                return new Set();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }
    }
}
