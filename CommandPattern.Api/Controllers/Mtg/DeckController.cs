using CommandPattern.Api.Services.Mtg.Decks;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class DeckController : ControllerBase<Deck, IDeckService>
    {
        public DeckController(IDeckService service) : base(service)
        {
        }
    }
}
