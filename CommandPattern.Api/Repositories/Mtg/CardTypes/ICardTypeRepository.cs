using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Repositories.Mtg.CardTypes
{
    public interface ICardTypeRepository : IRepositoryBase<CardType>
    {
    }
}
