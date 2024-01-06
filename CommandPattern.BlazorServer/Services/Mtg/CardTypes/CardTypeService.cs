using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.CardTypes
{
    public class CardTypeService : ServiceBase<CardType>, ICardTypeService
    {
        public CardTypeService(ApiServerClient apiServerClient) : base(apiServerClient, "CardType")
        {
        }
    }
}
