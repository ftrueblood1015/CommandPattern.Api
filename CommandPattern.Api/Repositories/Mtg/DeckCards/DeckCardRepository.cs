using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CommandPattern.Api.Repositories.Mtg.DeckCards
{
    public class DeckCardRepository : RepositoryBase<DeckCard, CommandPatternContext>, IDeckCardRepository
    {
        public DeckCardRepository(CommandPatternContext context) : base(context)
        {
        }
        public override IEnumerable<DeckCard> GetAll()
        {
            return Context.Set<DeckCard>()
                .Include(c => c.Card);
        }

        public override IEnumerable<DeckCard> Filter(Func<DeckCard, bool> predicate)
        {
            return Context.Set<DeckCard>().Include(c => c.Card).AsNoTracking().Where(predicate);
        }
    }
}
