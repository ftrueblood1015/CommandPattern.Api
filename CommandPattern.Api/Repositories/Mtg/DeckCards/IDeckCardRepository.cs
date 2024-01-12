using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Repositories.Mtg.DeckCards
{
    public interface IDeckCardRepository : IRepositoryBase<DeckCard>
    {
    }
}
