using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.ColorIdentities
{
    public partial class ColorIdentityDetail : DetailPageBase<ColorIdentity>
    {
        [Parameter]
        public int EntityId { get; set; }

        public ColorIdentity? Entity { get; set; } = new ColorIdentity();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<ColorIdentity> SetEntity()
        {
            if (EntityId == 0)
            {
                return new ColorIdentity();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }
    }
}
