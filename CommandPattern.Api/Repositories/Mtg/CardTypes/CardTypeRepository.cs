using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;

namespace CommandPattern.Api.Repositories.Mtg.CardTypes
{
    public class CardTypeRepository : RepositoryBase<CardType, CommandPatternContext>, ICardTypeRepository
    {
        public CardTypeRepository(CommandPatternContext context) : base(context)
        {
        }
    }
}
