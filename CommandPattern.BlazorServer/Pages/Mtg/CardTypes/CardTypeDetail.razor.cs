using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.CardTypes
{
    public partial class CardTypeDetail : DetailPageBase<CardType>
    {
        [Parameter]
        public int EntityId { get; set; }

        public CardType? Entity { get; set; } = new CardType();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<CardType> SetEntity()
        {
            if (EntityId == 0)
            {
                return new CardType();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }
    }
}
