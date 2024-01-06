using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Services;

namespace CommandPattern.Api.Services.Mtg.CardTypes
{
    public interface ICardTypeService : IEntityServiceBase<CardType>
    {
    }
}
