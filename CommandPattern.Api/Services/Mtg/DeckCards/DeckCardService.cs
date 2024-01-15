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

        IEnumerable<Domain.Models.Entities.Mtg.DeckCardTypeStats> IDeckCardService.GetCardPurposeStats(long DeckId)
        {
            var DeckCards = Repo.Filter(d => d.DeckId == DeckId);
            int TotalCards = DeckCards.Sum(x => x.Quantity);
            var UniquePurposes = new List<string> ();
            var Statistics = new List<Domain.Models.Entities.Mtg.DeckCardTypeStats> ();

            if (TotalCards <= 0)
            {
                return new List<Domain.Models.Entities.Mtg.DeckCardTypeStats>();
            }

            foreach (var deckCard in DeckCards)
            {
                if (!UniquePurposes.Contains(deckCard.Card!.CardPurpose!.Name!))
                {
                    UniquePurposes.Add(deckCard.Card.CardPurpose.Name!);
                }
            }

            foreach (var purpose in UniquePurposes)
            {
                var Stat = new Domain.Models.Entities.Mtg.DeckCardTypeStats(purpose);
                var matchingPurposes = DeckCards.Where(n => n.Card!.CardPurpose!.Name == purpose).Sum(x => x.Quantity);
                Stat.Percentage = ((double)matchingPurposes / (double)TotalCards) * (double)100;
                Statistics.Add(Stat);
            }

            return Statistics;
        }
    }
}
