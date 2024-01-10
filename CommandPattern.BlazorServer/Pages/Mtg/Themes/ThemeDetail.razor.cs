using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.Themes
{
    public partial class ThemeDetail : DetailPageBase<Theme>
    {
        [Parameter]
        public int EntityId { get; set; }

        public Theme? Entity { get; set; } = new Theme();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<Theme> SetEntity()
        {
            if (EntityId == 0)
            {
                return new Theme();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }
    }
}
