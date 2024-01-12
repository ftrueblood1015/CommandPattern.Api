using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.DeckCards
{
    public interface IDeckCardService : IServiceBase<DeckCard>
    {
        Task<IEnumerable<DeckCard>?> GetAllEntitiesFiltered(long id);
    }
}
