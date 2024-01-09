using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.Rarities
{
    public class RarityService : ServiceBase<Rarity>, IRarityService
    {
        public RarityService(ApiServerClient apiServerClient) : base(apiServerClient, "Rarity")
        {
        }
    }
}
