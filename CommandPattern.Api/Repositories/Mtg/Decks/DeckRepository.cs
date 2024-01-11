using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CommandPattern.Api.Repositories.Mtg.Decks
{
    public class DeckRepository : RepositoryBase<Deck, CommandPatternContext>, IDeckRepository
    {
        public DeckRepository(CommandPatternContext context) : base(context)
        {
        }

        public override IEnumerable<Deck> GetAll()
        {
            return Context.Set<Deck>()
                .Include(g => g.Guild)
                .Include(f => f.Format)
                .Include(t =>t.Theme);
        }
    }
}
