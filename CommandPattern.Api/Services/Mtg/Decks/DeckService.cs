using CommandPattern.Api.Repositories.Mtg.Decks;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.Decks
{
    public class DeckService : ServiceBase<Deck, IDeckRepository>, IDeckService
    {
        public DeckService(IRepositoryBase<Deck> repo) : base(repo)
        {
        }

        public override Deck Add(Deck entity)
        {
            try
            {
                entity.WinRate = 0;
                return Repo.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
