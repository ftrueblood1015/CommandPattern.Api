using CommandPattern.Api.Repositories.Mtg.CardPurposes;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.CardPurposes
{
    public class CardPurposeService : ServiceBase<CardPurpose, ICardPurposeRepository>, ICardPurposeService
    {
        public CardPurposeService(IRepositoryBase<CardPurpose> repo) : base(repo)
        {
        }
    }
}
