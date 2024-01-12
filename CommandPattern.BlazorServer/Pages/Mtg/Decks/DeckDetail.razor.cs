using CommandPattern.BlazorServer.Services.Mtg.DeckCards;
using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CommandPattern.BlazorServer.Pages.Mtg.Decks
{
    public partial class DeckDetail : DetailPageBase<Deck>
    {
        [Parameter]
        public long EntityId { get; set; }

        public Deck? Entity { get; set; } = new Deck();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<Deck> SetEntity()
        {
            if (EntityId == 0)
            {
                return new Deck() { WinRate = 0 };
            }
            else
            {
                return await base.GetEntity((int)EntityId);
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
