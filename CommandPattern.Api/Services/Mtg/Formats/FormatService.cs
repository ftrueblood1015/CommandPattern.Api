using CommandPattern.Api.Repositories.Mtg.Formats;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;
using CommandPattern.Domain.Services;

namespace CommandPattern.Api.Services.Mtg.Formats
{
    public class FormatService : ServiceBase<Format, IFormatRepository>, IFormatService
    {
        public FormatService(IRepositoryBase<Format> repo) : base(repo)
        {
        }
    }
}
