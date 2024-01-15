using CommandPattern.Api.Services.Mtg.DeckCards;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class DeckCardController : ControllerBase<DeckCard, IDeckCardService>
    {
        public DeckCardController(IDeckCardService service) : base(service)
        {
        }

        [HttpPost("filterByDeckId/{id}")]
        public ActionResult<string?> Filter(long id)
        {
            var result = Service.Filter(x => x.DeckId == id);
            return Ok(result);
        }

        [HttpPost("cardPurposeStatistics/{id}")]
        public ActionResult<string?> CardPurposeStatistics(long id)
        {
            var result = Service.GetCardPurposeStats(id);
            return Ok(result);
        }
    }
}
