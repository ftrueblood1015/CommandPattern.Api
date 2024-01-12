using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Services;

namespace CommandPattern.Api.Services.Mtg.DeckCards
{
    public interface IDeckCardService : IEntityServiceBase<DeckCard>
    {
    }
}
