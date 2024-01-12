using CommandPattern.Api.Repositories.Mtg.DeckCards;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.DeckCards
{
    public class DeckCardService : ServiceBase<DeckCard, IDeckCardRepository>, IDeckCardService
    {
        public DeckCardService(IRepositoryBase<DeckCard> repo) : base(repo)
        {
        }
    }
}
