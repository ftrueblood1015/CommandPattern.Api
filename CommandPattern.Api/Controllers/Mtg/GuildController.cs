using CommandPattern.Api.Services.Mtg.Guilds;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class GuildController : ControllerBase<Guild, IGuildService>
    {
        public GuildController(IGuildService service) : base(service)
        {
        }
    }
}
