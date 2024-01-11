using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Repositories.Mtg.Decks
{
    public interface IDeckRepository : IRepositoryBase<Deck>
    {
    }
}
