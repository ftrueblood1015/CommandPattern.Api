using CommandPattern.BlazorServer.Services.Mtg.DeckCards;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.DeckCards
{
    public partial class CardPurposeStats
    {
        [Inject]
        private IDeckCardService? DeckCardService { get; set; }

        [Parameter]
        public long DeckId { get; set; }

        [Parameter]
        public EventCallback<long> DeckIdChanged { get; set; }

        private List<CommandPattern.Domain.Models.Entities.Mtg.DeckCardTypeStats>? DeckCardStats { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await GetCardPurposeStats();
        }

        private async Task GetCardPurposeStats()
        {
            if (DeckCardService == null)
            {
                throw new ArgumentNullException(nameof(DeckCardService));
            }

            var Response = await DeckCardService.GetCardPurposeStatistics(DeckId);
            DeckCardStats = Response != null ? Response.ToList() : new List<CommandPattern.Domain.Models.Entities.Mtg.DeckCardTypeStats>();
        }
    }
}
