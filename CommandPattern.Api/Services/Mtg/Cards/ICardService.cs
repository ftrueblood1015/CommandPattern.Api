using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Services;

namespace CommandPattern.Api.Services.Mtg.Cards
{
    public interface ICardService : IEntityServiceBase<Card>
    {
    }
}
