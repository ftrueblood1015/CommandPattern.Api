using CommandPattern.Api.Services.Mtg.CardPurposes;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class CardPurposeController : ControllerBase<CardPurpose, ICardPurposeService>
    {
        public CardPurposeController(ICardPurposeService service) : base(service)
        {
        }
    }
}
