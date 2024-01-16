using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Services;

namespace CommandPattern.Api.Services.Mtg.DeckCards
{
    public interface IDeckCardService : IEntityServiceBase<DeckCard>
    {
        IEnumerable<CommandPattern.Domain.Models.Entities.Mtg.DeckCardTypeStats> GetCardPurposeStats(long DeckId);
        CommandPattern.Domain.Models.Entities.Mtg.CMCBarChartData GetDeckCMCChartData(long DeckId);
    }
}
