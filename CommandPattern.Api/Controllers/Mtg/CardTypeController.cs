using CommandPattern.Api.Services.Mtg.CardTypes;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class CardTypeController : ControllerBase<CardType, ICardTypeService>
    {
        public CardTypeController(ICardTypeService service) : base(service)
        {
        }
    }
}
