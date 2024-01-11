using CommandPattern.Domain.Entities.Mtg;

namespace CommandPattern.BlazorServer.Services.Mtg.Formats
{
    public class FormatService : ServiceBase<Format>
    {
        public FormatService(ApiServerClient apiServerClient) : base(apiServerClient, "Format")
        {
        }
    }
}
