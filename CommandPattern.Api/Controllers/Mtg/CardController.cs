using CommandPattern.Api.Services.Mtg.Cards;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class CardController : ControllerBase<Card, ICardService>
    {
        public CardController(ICardService service) : base(service)
        {
        }
    }
}
