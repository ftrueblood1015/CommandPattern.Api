using CommandPattern.Api.Services.Mtg.Sets;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class SetController : ControllerBase<Set, ISetService>
    {
        public SetController(ISetService service) : base(service)
        {
        }
    }
}
