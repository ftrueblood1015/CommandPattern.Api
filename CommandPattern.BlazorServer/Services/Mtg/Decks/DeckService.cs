using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.Decks
{
    public class DeckService : ServiceBase<Deck>
    {
        public DeckService(ApiServerClient apiServerClient) : base(apiServerClient, "Deck")
        {
        }
    }
}
