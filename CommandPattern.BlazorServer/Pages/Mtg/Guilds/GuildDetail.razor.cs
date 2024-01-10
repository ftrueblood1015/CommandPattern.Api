using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.Guilds
{
    public partial class GuildDetail : DetailPageBase<Guild>
    {
        [Parameter]
        public int EntityId { get; set; }

        public Guild? Entity { get; set; } = new Guild();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<Guild> SetEntity()
        {
            if (EntityId == 0)
            {
                return new Guild();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }
    }
}
