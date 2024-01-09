using CommandPattern.Api.Services.Mtg.Rarities;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class RarityController : ControllerBase<Rarity, IRarityService>
    {
        public RarityController(IRarityService service) : base(service)
        {
        }
    }
}
