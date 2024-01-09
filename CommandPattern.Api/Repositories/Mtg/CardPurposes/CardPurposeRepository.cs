using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Infrastructure;

namespace CommandPattern.Api.Repositories.Mtg.CardPurposes
{
    public class CardPurposeRepository : RepositoryBase<CardPurpose, CommandPatternContext>, ICardPurposeRepository
    {
        public CardPurposeRepository(CommandPatternContext context) : base(context)
        {
        }
    }
}
