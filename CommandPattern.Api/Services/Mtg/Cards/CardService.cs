using CommandPattern.Api.Repositories.Mtg.Cards;
using CommandPattern.Domain.Entities.Mtg;
using CommandPattern.Domain.Repositories;

namespace CommandPattern.Api.Services.Mtg.Cards
{
    public class CardService : ServiceBase<Card, ICardRepository>, ICardService
    {
        public CardService(IRepositoryBase<Card> repo) : base(repo)
        {
        }
    }
}
