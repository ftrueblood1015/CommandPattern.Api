using CommandPattern.BlazorServer.Services.Mtg.DeckCards;
using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CommandPattern.BlazorServer.Pages.Mtg.Decks
{
    public partial class DeckDetail : DetailPageBase<Deck>
    {
        [Inject]
        private IDeckCardService? DeckCardService { get; set; }

        [Parameter]
        public int EntityId { get; set; }

        public Deck? Entity { get; set; } = new Deck();

        private List<DeckCard>? DeckCards { get; set; }

        public MudForm? DeckCardForm;

        public DeckCard? DeckCard { get; set; } = new DeckCard();

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
                var result = await base.GetEntity(EntityId);
                if (result != null)
                {
                    await GetDeckCards();
                }

                return result;
            }
        }

        private async Task GetDeckCards()
        {
            if ( DeckCardService == null)
            {
                throw new ArgumentNullException(nameof(DeckCardService));
            }

            var Response = await DeckCardService.GetAllEntitiesFiltered(EntityId);
            DeckCards = Response != null ? Response.ToList() : new List<DeckCard>();
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

        public async Task DeckCardChange(long? Id)
        {
            DeckCard!.CardId = (long)Id!;
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

        private async void SaveDeckCard(DeckCard Entity)
        {
            try
            {
                // add what is needed to deck card and create it
                Entity.IsActive = true;
                Entity.Name = "Card";
                Entity.DeckId = EntityId;
                await DeckCardService!.InsertEntity(Entity);

                success = true;
                ShowSnackbarMessage($"Added New {Entity.Name}", MudBlazor.Color.Success);

                // reset form and deck card
                await DeckCardForm!.ResetAsync();
                DeckCard = new DeckCard() { CardId = 0 };

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
    }
}
