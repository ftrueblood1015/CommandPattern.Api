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

        public Domain.Models.Entities.Mtg.CMCBarChartData GetDeckCMCChartData(long DeckId)
        {
            var DeckCards = Repo.Filter(d => d.DeckId == DeckId && !d.Card!.CardType!.Name!.Contains("Land"));
            int TotalCards = DeckCards.Sum(x => x.Quantity);

            if (TotalCards <= 0)
            {
                return new Domain.Models.Entities.Mtg.CMCBarChartData("EMPTY");
            }

            var Name = DeckCards.First().Deck!.Name;
            var CMCData = new Domain.Models.Entities.Mtg.CMCBarChartData($"{Name!} Mana Curve");

            int MaxCMC = Math.Max((int)DeckCards.Max(x => x.Card!.ConvertedManaCost)!, 16);

            for (int i = 0; i <= MaxCMC; i++)
            {
                CMCData.XAxisLabels.Add(i.ToString());
            }

            foreach(var cmcData in CMCData.XAxisLabels)
            {
                int totalCards = DeckCards.Where(x => x.Card!.ConvertedManaCost == Int32.Parse(cmcData)).Sum(x => x.Quantity);
                CMCData.Data.Add(totalCards);
            }

            return CMCData;
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
