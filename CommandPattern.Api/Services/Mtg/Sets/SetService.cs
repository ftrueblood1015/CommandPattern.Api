using CommandPattern.Api.Repositories.Mtg.Sets;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.Sets
{
    public class SetService : ServiceBase<Set, ISetRepository>, ISetService
    {
        public SetService(IRepositoryBase<Set> repo) : base(repo)
        {
        }
    }
}
