using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.Cards
{
    public partial class CardDetail : DetailPageBase<Card>
    {
        [Parameter]
        public int EntityId { get; set; }

        public Card? Entity { get; set; } = new Card();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<Card> SetEntity()
        {
            if (EntityId == 0)
            {
                return new Card();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }

        public async Task SetChange(long? Id)
        {
            Entity!.SetId = (long)Id!;
        }

        public async Task TypeChange(long? Id)
        {
            Entity!.CardTypeId = (long)Id!;
        }

        public async Task ColorChange(long? Id)
        {
            Entity!.ColorIdentityId = (long)Id!;
        }

        public async Task RarityChange(long? Id)
        {
            Entity!.RarityId = (long)Id!;
        }

        public async Task PurposeChange(long? Id)
        {
            Entity!.CardPurposeId = (long)Id!;
        }
    }
}
