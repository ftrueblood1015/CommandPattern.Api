using CommandPattern.BlazorServer.Shared.Components;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Components;

namespace CommandPattern.BlazorServer.Pages.Mtg.CardPurposes
{
    public partial class CardPurposeDetail : DetailPageBase<CardPurpose>
    {
        [Parameter]
        public int EntityId { get; set; }

        public CardPurpose? Entity { get; set; } = new CardPurpose();

        protected override async Task OnInitializedAsync()
        {
            Entity = await SetEntity();
        }

        public async Task<CardPurpose> SetEntity()
        {
            if (EntityId == 0)
            {
                return new CardPurpose();
            }
            else
            {
                return await base.GetEntity(EntityId);
            }
        }
    }
}
