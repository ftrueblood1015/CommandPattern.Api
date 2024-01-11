using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Services;

namespace CommandPattern.Api.Services.Mtg.Decks
{
    public interface IDeckService : IEntityServiceBase<Deck>
    {
    }
}
