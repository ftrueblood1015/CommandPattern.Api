using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Repositories.Mtg.Cards
{
    public interface ICardRepository : IRepositoryBase<Card>
    {
    }
}
