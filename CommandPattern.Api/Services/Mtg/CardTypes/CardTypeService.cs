using CommandPattern.Api.Repositories.Mtg.CardTypes;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.CardTypes
{
    public class CardTypeService : ServiceBase<CardType, ICardTypeRepository>, ICardTypeService
    {
        public CardTypeService(IRepositoryBase<CardType> repo) : base(repo)
        {
        }
    }
}
