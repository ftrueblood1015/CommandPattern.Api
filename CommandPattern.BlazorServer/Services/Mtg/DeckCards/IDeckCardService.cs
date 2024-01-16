using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.DeckCards
{
    public interface IDeckCardService : IServiceBase<DeckCard>
    {
        Task<IEnumerable<DeckCard>?> GetAllEntitiesFiltered(long id);

        Task<IEnumerable<CommandPattern.Domain.Models.Entities.Mtg.DeckCardTypeStats>?> GetCardPurposeStatistics(long id);

        Task<CommandPattern.Domain.Models.Entities.Mtg.CMCBarChartData?> GetCMCDeckData(long id);
    }
}
