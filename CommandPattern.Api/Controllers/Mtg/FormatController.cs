using CommandPattern.Api.Services.Mtg.Formats;
using CommandPattern.Domain.Entities.Mtg;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.Api.Controllers.Mtg
{
    public class FormatController : ControllerBase<Format, IFormatService>
    {
        public FormatController(IFormatService service) : base(service)
        {
        }
    }
}
