using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.Cards
{
    public class CardService : ServiceBase<Card>
    {
        public CardService(ApiServerClient apiServerClient) : base(apiServerClient, "Card")
        {
        }
    }
}
