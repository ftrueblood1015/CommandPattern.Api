using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.ColorIdentities
{
    public class ColorIdentityService : ServiceBase<ColorIdentity>, IColorIdentityService
    {
        public ColorIdentityService(ApiServerClient apiServerClient) : base(apiServerClient, "ColorIdentity")
        {
        }
    }
}
