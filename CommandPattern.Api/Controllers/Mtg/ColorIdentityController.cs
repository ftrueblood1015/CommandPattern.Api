using CommandPattern.Api.Services.Mtg.ColorIdentities;
using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class ColorIdentityController : ControllerBase<ColorIdentity, IColorIdentityService>
    {
        public ColorIdentityController(IColorIdentityService service) : base(service)
        {
        }
    }
}
