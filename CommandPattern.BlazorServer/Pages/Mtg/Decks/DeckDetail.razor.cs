using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.Decks
{
    public partial class DeckDetail : DetailPageBase<Deck>
    {
        [Parameter]
        public int EntityId { get; set; }

        public Deck? Entity { get; set; } = new Deck();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<Deck> SetEntity()
        {
            if (EntityId == 0)
            {
                return new Deck();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }

        public async Task ThemeChange(long? Id)
        {
            Entity!.ThemeId = (long)Id!;
        }

        public async Task FormatChange(long? Id)
        {
            Entity!.FormatId = (long)Id!;
        }

        public async Task GuildChange(long? Id)
        {
            Entity!.GuildId = (long)Id!;
        }
    }
}
