using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;

namespace CommandPattern.Api.Repositories.Mtg.Cards
{
    public class CardRepository : RepositoryBase<Card, CommandPatternContext>, ICardRepository
    {
        public CardRepository(CommandPatternContext context) : base(context)
        {
        }

        public override IEnumerable<Card> GetAll()
        {
            return Context.Set<Card>()
                .Include(s => s.Set)
                .Include(t => t.CardType)
                .Include(c => c.ColorIdentity)
                .Include(r => r.Rarity)
                .Include(p => p.CardPurpose);
        }
    }
}
