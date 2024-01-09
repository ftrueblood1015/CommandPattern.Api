using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.CardPurposes
{
    public class CardPurposeService : ServiceBase<CardPurpose>, ICardPurposeService
    {
        public CardPurposeService(ApiServerClient apiServerClient) : base(apiServerClient, "CardPurpose")
        {
        }
    }
}
