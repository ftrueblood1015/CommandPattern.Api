using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Repositories.Mtg.CardPurposes
{
    public interface ICardPurposeRepository : IRepositoryBase<CardPurpose>
    {
    }
}
