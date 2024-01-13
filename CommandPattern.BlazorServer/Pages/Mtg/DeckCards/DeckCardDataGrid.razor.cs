using CommandPattern.BlazorServer.Services.Mtg.DeckCards;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CommandPattern.BlazorServer.Pages.Mtg.DeckCards
{
    public partial class DeckCardDataGrid
    {
        [Inject]
        private IDeckCardService? DeckCardService { get; set; }

        [Inject]
        private ISnackbar? SnackbarService { get; set; }

        [Parameter]
        public long DeckId { get; set; }

        [Parameter]
        public EventCallback<long> DeckIdChanged { get; set; }

        private List<DeckCard>? DeckCards { get; set; }

        public MudForm? Form;

        public DeckCard? Entity { get; set; } = new DeckCard();

        public bool success;

        protected override async Task OnParametersSetAsync()
        {
            await GetDeckCards();
        }

        private async Task GetDeckCards()
        {
            if (DeckCardService == null)
            {
                throw new ArgumentNullException(nameof(DeckCardService));
            }

            var Response = await DeckCardService.GetAllEntitiesFiltered(DeckId);
            DeckCards = Response != null ? Response.ToList() : new List<DeckCard>();
        }

        public async Task CardChange(Card? card)
        {
            if (card != null)
            {
                Entity!.CardId = card!.Id;
                Entity!.Card = card;
            }
        }

        private async void SaveDeckCard(DeckCard Entity)
        {
            try
            {
                // add what is needed to deck card and create it
                Entity.IsActive = true;
                Entity.Name = "Card";
                Entity.DeckId = DeckId;
                Entity.Card = null;
                await DeckCardService!.InsertEntity(Entity);

                success = true;
                ShowSnackbarMessage($"Added New {Entity.Name}", MudBlazor.Color.Success);

                // reset form and deck card
                await Form!.ResetAsync();
                Entity = new DeckCard() { CardId = 0 };

                // refresh deck card data grid
                await GetDeckCards();
                StateHasChanged();
            }
            catch
            {
                success = false;
                ShowSnackbarMessage($"Could Not Add {Entity.Name}", MudBlazor.Color.Error);
            }
        }

        private async Task<bool> RemoveDeckCard(DeckCard Item)
        {
            if (DeckCardService == null)
            {
                throw new Exception($"{nameof(DeckCardService)} is null!");
            }

            try
            {
                var result = await DeckCardService.DeleteEntity(Item.Id);

                if (result)
                {
                    ShowSnackbarMessage($"Deleted {Item.Name}", MudBlazor.Color.Success);
                    await GetDeckCards();
                }
                else
                {
                    ShowSnackbarMessage($"Could Not Delete {Item.Name}", MudBlazor.Color.Error);
                }

                return result;
            }
            catch (Exception ex)
            {
                ShowSnackbarMessage($"Could Not Delete {Item.Name}: {ex}", MudBlazor.Color.Error);
                return false;
            }
        }

        public void ShowSnackbarMessage(string Message, MudBlazor.Color Color)
        {
            if (SnackbarService == null)
            {
                throw new ArgumentNullException(nameof(SnackbarService));
            }

            SnackbarService.Add<MudChip>(new Dictionary<string, object>() {
                { "Text", $"{Message}" },
                { "Color", Color }
            });
        }
    }
}
