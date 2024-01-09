using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.Rarities
{
    public partial class RarityDetail : DetailPageBase<Rarity>
    {
        [Parameter]
        public int EntityId { get; set; }

        public Rarity? Entity { get; set; } = new Rarity();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<Rarity> SetEntity()
        {
            if (EntityId == 0)
            {
                return new Rarity();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }
    }
}
